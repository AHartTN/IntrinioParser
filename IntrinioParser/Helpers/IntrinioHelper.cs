using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using CsvHelper;
using IntrinioParser.Classes;
using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Enumerators;
using IntrinioParser.Mapping.CSV.Detail;
using IntrinioParser.Mapping.CSV.Master;
using IntrinioParser.Models;
using IntrinioParser.Properties;
using Newtonsoft.Json;

namespace IntrinioParser.Helpers
{
	internal sealed class IntrinioHelper
	{
		public const string BaseURL = @"http://api.intrinio.com/";
		public const string CompanyRoute = "companies";
		public const string SecurityRoute = "securities";
		public const string IndexRoute = "indices";
		public const string OwnerRoute = "owners";
		public const string ExchangeRoute = "stock_exchanges";


		public IntrinioHelper(string username = null, string password = null, string workingDirectory = null)
		{
			Username = username ?? Resources.Intrinio_Username;
			Password = password ?? Resources.Intrinio_Password;
			WorkingDirectory = workingDirectory ?? Resources.Intrinio_Directory;
			DB = new IntrinioDatabase();

			Initialize();
		}

		private string Username { get; }
		private string Password { get; }
		private string WorkingDirectory { get; }
		private string RawAuthString => $"{Username}:{Password}";
		private byte[] AuthStringBytes => Encoding.GetEncoding("ISO-8859-1").GetBytes(RawAuthString);
		private string AuthString => $"Basic {Convert.ToBase64String(AuthStringBytes)}";
		private IntrinioDatabase DB { get; }

		private void Initialize()
		{
			IntrinioDatabaseInitializer.Initialize(DB);
		}

		private void RegisterCSVClassMaps(CsvReader reader)
		{
			reader?.Configuration.RegisterClassMap(new CompanyMasterCSVMap());
			reader?.Configuration.RegisterClassMap(new SecurityMasterCSVMap());
			reader?.Configuration.RegisterClassMap(new IndexMasterCSVMap());
			reader?.Configuration.RegisterClassMap(new OwnerMasterCSVMap());
			reader?.Configuration.RegisterClassMap(new StockExchangeMasterCSVMap());

			reader?.Configuration.RegisterClassMap(new CompanyCSVMap());
			reader?.Configuration.RegisterClassMap(new SecurityCSVMap());
			reader?.Configuration.RegisterClassMap(new IndexCSVMap());
			//reader?.Configuration.RegisterClassMap(new OwnerCSVMap());
			//reader?.Configuration.RegisterClassMap(new StockExchangeCSVMap());
		}

		private CsvReader GetCSVReader(TextReader stream)
		{
			CsvReader reader = new CsvReader(stream);
			RegisterCSVClassMaps(reader);
			return reader;
		}

		private string GetTableName<T>() where T : IntrinioAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException(
					$"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			return instance.FullTableName;
		}

		private string BuildURL<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException(
					$"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			DataType dataType = instance.DataType;
			FileType fileType = instance.FileType;

			string route;

			switch (dataType)
			{
				case DataType.Company:
					route = CompanyRoute;
					break;
				case DataType.Security:
					route = SecurityRoute;
					break;
				case DataType.Index:
					route = IndexRoute;
					break;
				case DataType.Owner:
					route = OwnerRoute;
					break;
				case DataType.StockExchange:
					route = ExchangeRoute;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(dataType), dataType, null);
			}

			string url = Path.Combine(BaseURL, route);

			switch (fileType)
			{
				case FileType.CSV:
					url += ".csv";
					break;
				case FileType.JSON:
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(fileType), fileType, null);
			}

			url += arguments.BuildQueryString();

			return url;
		}

		private string BuildFilePath<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException(
					$"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			FileType fileType = instance.FileType;
			string hash = $"{typeof(T).FullName}{arguments.BuildQueryString()}".Hash();
			string filePath = Path.Combine(WorkingDirectory, $"{hash}");

			switch (fileType)
			{
				case FileType.CSV:
					filePath += ".csv";
					break;
				case FileType.JSON:
					filePath += ".json";
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(fileType), $"Unable to Get<T>(): Unknown file type - ({fileType})");
			}

			return filePath;
		}

		private HttpWebRequest BuildRequest<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			string url = BuildURL<T>(arguments);
			Console.WriteLine(url);
			HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
			request.Timeout = 60000;
			request.Headers.Add("Authorization", AuthString);

			return request;
		}

		private IReadOnlyCollection<T> ProcessResponse<T>(Dictionary<string, string> arguments = null)
			where T : IntrinioAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException(
					$"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			if (arguments == null)
				arguments = new Dictionary<string, string>();

			FileType fileType = instance.FileType;

			HttpWebRequest request = BuildRequest<T>(arguments);

			List<T> records = new List<T>();
			int currentPage = 1;
			int totalPages = 1;

			using (HttpWebResponse initialResponse = (HttpWebResponse) request.GetResponse())
			{
				using (Stream responseStream = initialResponse.GetResponseStream())
				{
					if (responseStream == null)
						throw new ArgumentNullException(nameof(responseStream),
							$"The Stream response received from the initial response that {request.RequestUri} gave is null or contained no value.");

					using (StreamReader stream = new StreamReader(responseStream))
					{
						// ISSUE: An error gets thrown when we first try to get the response... request.GetResponse() has error handling and throws an exception with the message/code.
						// TODO: Refactor this to better handle exceptions
						switch (initialResponse.StatusCode)
						{
							case HttpStatusCode.OK: // You greedy bastard
								switch (fileType)
								{
									case FileType.CSV:
										Dictionary<string, string> results = stream.ReadLine()?.Split(",").Select(rawResult => rawResult.Split(":"))
											.ToDictionary(resultArray => resultArray[0].Trim(), resultArray => resultArray[1].Trim());

										if (results == null || !results.Any())
											throw new ArgumentNullException(nameof(results),
												"The API response result was not properly retrieved. Unable to determine paging!");

										records.AddRange(ProcessCSVResponse<T>(stream));

										if (results.ContainsKey("CURRENT_PAGE"))
										{
											currentPage = int.Parse(results["CURRENT_PAGE"]);
											totalPages = int.Parse(results["TOTAL_PAGES"]);
										}
										break;
									case FileType.JSON:
										JsonResponse<T> response = ProcessJSONResponse<T>(stream);
										records.AddRange(response.Data);

										currentPage = response.CurrentPage;
										totalPages = response.TotalPages;
										break;
									default:
										throw new ArgumentOutOfRangeException(nameof(fileType),
											$"Unable to Process Response. {fileType} is not known to be a valid file type code utilized by the Intrinio Parser!");
								}
								break;
							case HttpStatusCode.Unauthorized: // API Username/Password not set properly
							case HttpStatusCode.Forbidden: // Limit reached or banned?
							case HttpStatusCode.NotFound: // Invalid path
							case HttpStatusCode.InternalServerError: // Server Error
							case HttpStatusCode.ServiceUnavailable: // Service Interruption or limit reached
							case (HttpStatusCode) 429: // Too many calls
								string errorResponse = stream.ReadToEnd();
								throw new Exception(errorResponse);
							default:
								throw new ArgumentOutOfRangeException(nameof(initialResponse.StatusCode),
									$"Unable to Process Response. {initialResponse.StatusCode} is not known to be a status code returned by Intrinio!");
						}
					}
				}
			}

			if (currentPage < totalPages)
			{
				currentPage++;

				if (arguments.ContainsKey("page_number"))
					arguments["page_number"] = currentPage.ToString();
				else
					arguments.Add("page_number", currentPage.ToString());

				//Thread.Sleep(50);

				records.AddRange(ProcessResponse<T>(arguments));
			}

			return records;
		}

		private IReadOnlyCollection<T> ProcessCSVResponse<T>(StreamReader stream) where T : IntrinioAbstract
		{
			if (stream == null || stream.Peek() == -1)
				return null;
			//string[] columns = stream.ReadLine().Split(',');
			//foreach(string column in columns)
			//	Console.WriteLine(column);
			CsvReader reader = GetCSVReader(stream);
			IReadOnlyCollection<T> records = reader.GetRecords<T>().ToArray();

			return records;
		}

		private JsonResponse<T> ProcessJSONResponse<T>(StreamReader stream) where T : IntrinioAbstract
		{
			string jsonString = stream.ReadToEnd();
			//Console.WriteLine(jsonString);
			JsonResponse<T> result = JsonConvert.DeserializeObject<JsonResponse<T>>(jsonString);

			if (result?.Data != null)
				return result;

			T record = JsonConvert.DeserializeObject<T>(jsonString);
			result = new JsonResponse<T>
			{
				ResultCount = 1,
				PageSize = 1,
				CurrentPage = 1,
				TotalPages = 1,
				APICallCredits = 1,
				Data = new[] {record}
			};

			return result;
		}

		public IReadOnlyCollection<T> Get<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			bool updateSQL = false;
			bool updateFile = false;

			// Try to retrieve from SQL Database first
			IReadOnlyCollection<T> records = GetSQL<T>(arguments);

			// Check if we found any records
			if (records == null || !records.Any())
			{
				// No records found, we need to update SQL
				updateSQL = true;
				// Lets try retrieving by file instead since SQL failed
				records = GetFile<T>(arguments);
			}

			// We'll check again to ensure we have records from either GetSQL<T> or GetFile<T>
			if (records == null || !records.Any())
			{
				// Still no records... File needs updating as well
				updateFile = true;
				// Final attempt... Let's retrieve the information from the API
				records = GetAPI<T>(arguments);
			}

			// Third check for records. If SQL or File returned records, we'll bypass this with no problems.
			if (records == null || !records.Any())
				throw new ArgumentNullException(nameof(records),
					$"We were unable to return any {typeof(T)} records from SQL, File, or the Intrinio API.");

			// Okay, at this point we should have records finally...
			// Let's flex!

			int rowCount = records.Count;

			Console.WriteLine(
				$"{rowCount} records were retrieved! - Update SQL: {updateSQL} | Update File: {updateFile} | Type: {typeof(T)}");

			// Do we need to update the file?
			if (updateFile)
			{
				// Writen to file here
				// filePath.WriteFile(response.CSVString);
				string output = JsonConvert.SerializeObject(records);
				BuildFilePath<T>(arguments).WriteFile(output);
			}

			// Do we need to update SQL?
			if (updateSQL)
				using (SqlConnection conn = new SqlConnection(IntrinioDatabase.DefaultConnectionString))
				{
					if (!records.WriteToDatabase(conn, SqlBulkCopyOptions.Default))
						throw new SqlNotFilledException(
							$"It would appear that the write to the SQL database has failed for {typeof(T)}.");
				}

			// Did we update the SQL or File information? Let's go ahead and retrieve the information from SQL again so we have IDs and everything...
			if (updateFile || updateSQL)
				records = GetSQL<T>();

			// Final check for records...
			if (records == null || !records.Any())
				throw new ArgumentNullException(nameof(records),
					$"{typeof(T)} records were retrieved from from SQL, File, or the Intrinio API but we were unable to write the results to file or the SQL database. Were there any records returned?");

			return records;
		}

		public IReadOnlyCollection<T> GetSQL<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			IntrinioDatabase db = new IntrinioDatabase();
			IReadOnlyCollection<T> records = db.Set<T>().ToArray();
			return records;
		}

		public IReadOnlyCollection<T> GetFile<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			// Retrieve collection from file
			string filePath = BuildFilePath<T>(arguments);
			FileInfo fileInfo = new FileInfo(filePath);

			if (!fileInfo.Exists)
				return null;

			string fileContents = File.ReadAllText(filePath);
			IReadOnlyCollection<T> records = JsonConvert.DeserializeObject<IReadOnlyCollection<T>>(fileContents);
			return records;
		}

		public IReadOnlyCollection<T> GetAPI<T>(Dictionary<string, string> arguments = null) where T : IntrinioAbstract
		{
			// Retrieve from API
			IReadOnlyCollection<T> results = ProcessResponse<T>(arguments);
			return results;
		}
	}
}