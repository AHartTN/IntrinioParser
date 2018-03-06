namespace IntrinioParser.Helpers
{
	#region
	using System;
	using System.Collections.Generic;
	using System.Data.SqlClient;
	using System.Data.SqlTypes;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Text;
	using System.Threading;

	using Classes;
	using Classes.Abstract.Base;

	using CsvHelper;

	using Enumerators;

	using Mapping.CSV.Detail;
	using Mapping.CSV.Master;

	using Models;

	using Newtonsoft.Json;

	using Properties;
	#endregion

	internal sealed class IntrinioHelper
	{
		private string Username { get; }
		private string Password { get; }
		private string WorkingDirectory { get; }
		private string RawAuthString => $"{Username}:{Password}";

		private byte[] AuthStringBytes => Encoding.GetEncoding("ISO-8859-1")
												  .GetBytes(RawAuthString);

		private string AuthString => $"Basic {Convert.ToBase64String(AuthStringBytes)}";
		private IntrinioDatabase DB { get; }

		internal IntrinioHelper(string username = null,
								string password = null,
								string workingDirectory = null)
		{
			Username = username ?? Resources.Intrinio_Username;
			Password = password ?? Resources.Intrinio_Password;
			WorkingDirectory = workingDirectory ?? Resources.Intrinio_Directory;
			DB = new IntrinioDatabase();

			Initialize();
		}

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
			reader?.Configuration.RegisterClassMap(new OwnerCSVMap());
			//reader?.Configuration.RegisterClassMap(new StockExchangeCSVMap());
		}

		private CsvReader GetCSVReader(TextReader stream)
		{
			CsvReader reader = new CsvReader(stream);
			RegisterCSVClassMaps(reader);
			return reader;
		}

		private string BuildURL<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException($"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			IntrinioDataType dataType = instance.DataType;
			FileType fileType = instance.FileType;

			string route;

			switch (dataType)
			{
				case IntrinioDataType.Companies:
					route = CompaniesRoute;
					break;
				case IntrinioDataType.Securities:
					route = SecuritiesRoute;
					break;
				case IntrinioDataType.Indices:
					route = IndicesRoute;
					break;
				case IntrinioDataType.Owners:
					route = OwnersRoute;
					break;
				case IntrinioDataType.StockExchanges:
					route = StockExchangesRoute;
					break;
				case IntrinioDataType.AccessLimits:
					route = AccessLimitsRoute;
					break;
				case IntrinioDataType.CurrentLimits:
					route = CurrentLimitsRoute;
					break;
				case IntrinioDataType.HistoricalLimits:
					route = HistoricalLimitsRoute;
					break;
				case IntrinioDataType.SecuritiesSearch:
					route = SecuritiesSearchRoute;
					break;
				case IntrinioDataType.DataPoint:
					route = DataPointRoute;
					break;
				case IntrinioDataType.HistoricalData:
					route = HistoricalDataRoute;
					break;
				case IntrinioDataType.Prices:
					route = PricesRoute;
					break;
				case IntrinioDataType.ExchangePrices:
					route = ExchangePricesRoute;
					break;
				case IntrinioDataType.LatestSECFilings:
					route = FilingsRoute;
					break;
				case IntrinioDataType.CompanySECFilings:
					route = CompanyFilingsRoute;
					break;
				case IntrinioDataType.CompanyNews:
					route = NewsRoute;
					break;
				case IntrinioDataType.StandardizedFundamentals:
					route = StandardizedFundamentalsRoute;
					break;
				case IntrinioDataType.StandardizedTagsAndLabels:
					route = StandardizedTagsRoute;
					break;
				case IntrinioDataType.StandardizedFinancials:
					route = StandarizedFinancialsRoute;
					break;
				case IntrinioDataType.AsReportedFundamentals:
					route = AsReportedFundamentalsRoute;
					break;
				case IntrinioDataType.AsReportedXBRLTagsAndLabels:
					route = AsReportedTagsRoute;
					break;
				case IntrinioDataType.AsReportedFinancials:
					route = AsReportedFinancialsRoute;
					break;
				case IntrinioDataType.CreateValuation:
					route = ValuationRoute;
					break;
				case IntrinioDataType.FetchValuation:
					route = ValuationRouteTemplate;
					break;
				case IntrinioDataType.FetchValuationAssumptions:
				case IntrinioDataType.ChangeValuationAssumptions:
					route = ValuationAssumptionRouteTemplate;
					break;
				case IntrinioDataType.FetchValuationOutputs:
					route = ValuationOutputsRouteTemplate;
					break;
				case IntrinioDataType.InsiderTransactionsByCompany:
					route = CompanyInsiderTransactionsRoute;
					break;
				case IntrinioDataType.InsiderOwnershipByCompany:
					route = CompanyInsiderOwnershipRoute;
					break;
				case IntrinioDataType.InsiderTransactionsByOwner:
					route = OwnerInsiderTransactionsRoute;
					break;
				case IntrinioDataType.InsiderHoldingsByOwner:
					route = OwnerInsiderHoldingsRoute;
					break;
				case IntrinioDataType.InstitutionalHoldingsByOwner:
					route = OwnerInstitutionalHoldingsRoute;
					break;
				case IntrinioDataType.InstitutionalOwnersBySecurity:
					route = SecurityInstitutionalOwnershipRoute;
					break;
				case IntrinioDataType.Banks:
					route = BanksRoute;
					break;
				case IntrinioDataType.BankHoldingCompanies:
					route = BankHoldingCompaniesRoute;
					break;
				case IntrinioDataType.BankBranches:
					route = BankBranchesRoute;
					break;
				case IntrinioDataType.FailedBanks:
					route = FailedBanksRoute;
					break;
				case IntrinioDataType.BankFundamentals:
					route = BankFundamentalsRoute;
					break;
				case IntrinioDataType.BankXBRLTagsAndLabels:
					route = BankTagsRoute;
					break;
				case IntrinioDataType.BankFinancials:
					route = BankFinancialsRoute;
					break;
				case IntrinioDataType.SecurityCorporateActions:
					route = SecurityCorporateActionsRoute;
					break;
				case IntrinioDataType.StockExchangeCorporateActions:
					route = StockExchangeCorporateActionsRoute;
					break;
				case IntrinioDataType.SecuritiesSalesSuprises:
					route = SecuritySalesSuprisesRoute;
					break;
				case IntrinioDataType.SecuritiesEPSSuprises:
					route = SecurityEPSSuprisesRoute;
					break;
				case IntrinioDataType.Options:
					route = OptionsRoute;
					break;
				case IntrinioDataType.OptionExpirations:
					route = OptionExpirationsRoute;
					break;
				case IntrinioDataType.CurrentOptionPrices:
					route = CurrentOptionPriceRoute;
					break;
				case IntrinioDataType.HistoricalOptionPrices:
					route = HistoricalOptionPriceRoute;
					break;
				case IntrinioDataType.SecurityNewsSentiments:
					route = NewsSentimentsRoute;
					break;
				case IntrinioDataType.SectorNewsSentiments:
					route = NewsSectorSentiments;
					break;
				case IntrinioDataType.Bloggers:
					route = BloggersRoute;
					break;
				case IntrinioDataType.Blogs:
					route = BlogsRoute;
					break;
				case IntrinioDataType.BloggerRatings:
					route = BloggerRatingsRoute;
					break;
				case IntrinioDataType.Analysts:
					route = AnalystsRoute;
					break;
				case IntrinioDataType.AnalystFirms:
					route = AnalystFirmsRoute;
					break;
				case IntrinioDataType.AnalystRatings:
					route = AnalystRatingsRoute;
					break;
				case IntrinioDataType.PressReleases:
					route = PressReleasesRoute;
					break;
				case IntrinioDataType.PressReleaseContent:
					route = PressReleaseContentRoute;
					break;
				case IntrinioDataType.Executives:
					route = ExecutivesRoute;
					break;
				case IntrinioDataType.ExecutiveDetails:
					route = ExecutiveDetailsRoute;
					break;
				case IntrinioDataType.CompanyExecutiveContacts:
					route = CompanyExecutiveContactsRoute;
					break;
				case IntrinioDataType.CompanyExecutiveCompensation:
					route = ExecutiveCompensationsRoute;
					break;
				case IntrinioDataType.CompanyExecutiveRoles:
					route = ExecutiveRolesRoute;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(dataType),
														  dataType,
														  null);
			}

			string url = Path.Combine(BaseURL,
									  route);

			switch (fileType)
			{
				case FileType.CSV:
					url += ".csv";
					break;
				case FileType.JSON:
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(fileType),
														  fileType,
														  null);
			}

			url += arguments.BuildQueryString();

			return url;
		}

		private string BuildFilePath<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException($"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			FileType fileType = instance.FileType;
			string hash = $"{typeof(T).FullName}{arguments.BuildQueryString()}".Hash();
			string filePath = Path.Combine(WorkingDirectory,
										   $"{hash}");

			switch (fileType)
			{
				case FileType.CSV:
					filePath += ".csv";
					break;
				case FileType.JSON:
					filePath += ".json";
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(fileType),
														  $"Unable to Get<T>(): Unknown file type - ({fileType})");
			}

			return filePath;
		}

		private HttpWebRequest BuildRequest<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			string url = BuildURL<T>(arguments);
			Console.WriteLine(url);
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Timeout = 60000;
			request.Headers.Add("Authorization",
								AuthString);

			return request;
		}

		private IReadOnlyCollection<T> ProcessCSVResponse<T>(StreamReader stream)
			where T : BaseAbstract
		{
			if (stream == null
				|| stream.Peek() == -1)
				return null;
			//string[] columns = stream.ReadLine().Split(',');
			//foreach (string column in columns)
			//	Console.WriteLine(column);
			CsvReader reader = GetCSVReader(stream);
			IReadOnlyCollection<T> records = reader.GetRecords<T>()
												   .ToArray();

			return records;
		}

		private JsonResponse<T> ProcessJSONResponse<T>(StreamReader stream)
			where T : BaseAbstract
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
						 Data = new[]
								{
									record
								}
					 };

			return result;
		}

		private IReadOnlyCollection<T> ProcessResponse<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException($"Unable to retrieve information for {typeof(T)} as it does not appear to be an Intrinio related object.");

			if (arguments == null)
				arguments = new Dictionary<string, string>();

			FileType fileType = instance.FileType;

			HttpWebRequest request = BuildRequest<T>(arguments);

			List<T> records = new List<T>();
			int currentPage = 1;
			int totalPages = 1;

			using (HttpWebResponse initialResponse = (HttpWebResponse)request.GetResponse())
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
										Dictionary<string, string> results = stream.ReadLine()
																				   ?.Split(",")
																				   .Select(rawResult => rawResult.Split(":"))
																				   .ToDictionary(resultArray => resultArray[0]
																									 .Trim(),
																								 resultArray => resultArray[1]
																									 .Trim());

										if (results == null
											|| !results.Any())
											throw new ArgumentNullException(nameof(results),
																			"The API response result was not properly retrieved. Unable to determine paging!");

										IReadOnlyCollection<T> responseRecords = ProcessCSVResponse<T>(stream);

										if (responseRecords != null
											&& responseRecords.Any())
											records.AddRange(responseRecords);

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
							case (HttpStatusCode)429: // Too many calls
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
					arguments.Add("page_number",
								  currentPage.ToString());

				Thread.Sleep(500);

				records.AddRange(ProcessResponse<T>(arguments));
			}

			return records;
		}

		private IReadOnlyCollection<T> GetSQL<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			IntrinioDatabase db = new IntrinioDatabase();
			IReadOnlyCollection<T> records = db.Set<T>()
											   .ToArray();
			return records;
		}

		private IReadOnlyCollection<T> GetFile<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
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

		private IReadOnlyCollection<T> GetAPI<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			// Retrieve from API
			IReadOnlyCollection<T> results = ProcessResponse<T>(arguments);
			return results;
		}

		public IReadOnlyCollection<T> Get<T>(Dictionary<string, string> arguments = null)
			where T : BaseAbstract
		{
			bool updateSQL = false;
			bool updateFile = false;

			// Try to retrieve from SQL Database first
			IReadOnlyCollection<T> records = GetSQL<T>(arguments);

			// Check if we found any records
			if (records == null
				|| !records.Any())
			{
				// No records found, we need to update SQL
				updateSQL = true;
				// Lets try retrieving by file instead since SQL failed
				records = GetFile<T>(arguments);
			}

			// We'll check again to ensure we have records from either GetSQL<T> or GetFile<T>
			if (records == null
				|| !records.Any())
			{
				// Still no records... File needs updating as well
				updateFile = true;
				// Final attempt... Let's retrieve the information from the API
				records = GetAPI<T>(arguments);
			}

			// Third check for records. If SQL or File returned records, we'll bypass this with no problems.
			if (records == null
				|| !records.Any())
				throw new ArgumentNullException(nameof(records),
												$"We were unable to return any {typeof(T)} records from SQL, File, or the Intrinio API.");

			// Okay, at this point we should have records finally...
			// Let's flex!

			int rowCount = records.Count;

			Console.WriteLine($"{rowCount} records were retrieved! - Update SQL: {updateSQL} | Update File: {updateFile} | Type: {typeof(T)}");

			// Do we need to update the file?
			if (updateFile)
			{
				// Writen to file here
				// filePath.WriteFile(response.CSVString);
				string output = JsonConvert.SerializeObject(records);
				BuildFilePath<T>(arguments)
					.WriteFile(output);
			}

			// Do we need to update SQL?
			if (updateSQL)
				using (SqlConnection conn = new SqlConnection(IntrinioDatabase.DefaultConnectionString))
				{
					if (!records.WriteToDatabase(conn,
												 SqlBulkCopyOptions.Default))
						throw new SqlNotFilledException($"It would appear that the write to the SQL database has failed for {typeof(T)}.");
				}

			// Did we update the SQL or File information? Let's go ahead and retrieve the information from SQL again so we have IDs and everything...
			if (updateFile || updateSQL)
				records = GetSQL<T>();

			// Final check for records...
			if (records == null
				|| !records.Any())
				throw new ArgumentNullException(nameof(records),
												$"{typeof(T)} records were retrieved from from SQL, File, or the Intrinio API but we were unable to write the results to file or the SQL database. Were there any records returned?");

			return records;
		}

		#region Route constants
		private const string BaseURL = @"https://api.intrinio.com/";
		private const string QUODDURL = @"https://www5.quodd.com/quoddsnap/c/intrinio/t/";
		private const string AccessRoute = "access";
		private const string AnalystsRoute = "analysts";
		private const string AnalystFirmsRoute = "analyst_firms";
		private const string AnalystRatingsRoute = "analyst_ratings";
		private const string AssumptionsRoute = "assumptions";
		private const string BanksRoute = "banks";
		private const string BlogsRoute = "blogs";
		private const string BloggerRatingsRoute = "blogger_ratings";
		private const string BloggersRoute = "bloggers";
		private const string BranchesRoute = "branches";
		private const string CompaniesRoute = "companies";
		private const string CompensationsRoute = "compensations";
		private const string CorporateActionsRoute = "corporate_actions";
		private const string CurrentRoute = "current";
		private const string DataPointRoute = "data_point";
		private const string DetailRoute = "detail";
		private const string DetailsRoute = "details";
		private const string EPSRoute = "eps";
		private const string ExchangeRoute = "exchange";
		private const string ExecutivesRoute = "executives";
		private const string ExpirationsRoute = "expirations";
		private const string FailedRoute = "failed";
		private const string FilingsRoute = "filings";
		private const string FinancialsRoute = "financials";
		private const string FundamentalsRoute = "fundamentals";
		private const string HistoricalRoute = "historical";
		private const string HistoricalDataRoute = "historical_data";
		private const string HoldingCompaniesRoute = "holding_companies";
		private const string InsiderHoldingsRoute = "insider_holdings";
		private const string InsiderOwnershipRoute = "insider_ownership";
		private const string InsiderTransactionsRoute = "insider_transactions";
		private const string InstitutionalHoldingsRoute = "institutional_holdings";
		private const string InstitutionalOwnershipRoute = "institutional_ownership";
		//private const string InstitutionalTransactionsRoute = "institutional_transactions";
		private const string IndicesRoute = "indices";
		private const string OutputsRoute = "outputs";
		private const string NewsRoute = "news";
		private const string NewsSentimentsRoute = "news_sentiments";
		private const string NewsSectorSentiments = "news_sector_sentiments";
		private const string OptionsRoute = "options";
		private const string OwnersRoute = "owners";
		private const string PressReleasesRoute = "press_releases";
		private const string PricesRoute = "prices";
		private const string RolesRoute = "roles";
		private const string ReportedRoute = "reported";
		private const string SearchRoute = "search";
		private const string StandardizedRoute = "standardized";
		private const string SalesRoute = "sales";
		private const string SecuritiesRoute = "securities";
		private const string StockExchangesRoute = "stock_exchanges";
		private const string SuprisesRoute = "suprises";
		private const string TagsRoute = "tags";
		private const string TokenRoute = "token";
		private const string UsageRoute = "usage";
		private const string ValuationRoute = "valuation";

		private const string CompanyFilingsRoute = CompaniesRoute + "/" + FilingsRoute;
		private const string StandarizedFinancialsRoute = FinancialsRoute + "/" + StandardizedRoute;
		private const string AsReportedFundamentalsRoute = FundamentalsRoute + "/" + ReportedRoute;
		private const string AsReportedTagsRoute = TagsRoute + "/" + ReportedRoute;
		private const string AsReportedFinancialsRoute = FinancialsRoute + "/" + ReportedRoute;
		private const string StandardizedFundamentalsRoute = FundamentalsRoute + "/" + StandardizedRoute;
		private const string ExchangePricesRoute = PricesRoute + "/" + ExchangeRoute;
		private const string StandardizedTagsRoute = TagsRoute + "/" + StandardizedRoute;
		private const string AccessLimitsRoute = UsageRoute + "/" + AccessRoute;
		private const string CurrentLimitsRoute = UsageRoute + "/" + CurrentRoute;
		private const string HistoricalLimitsRoute = UsageRoute + "/" + HistoricalRoute;
		private const string SecuritiesSearchRoute = SecuritiesRoute + "/" + SearchRoute;
		private const string BankHoldingCompaniesRoute = BanksRoute + "/" + HoldingCompaniesRoute;
		private const string BankBranchesRoute = BanksRoute + "/" + BranchesRoute;
		private const string FailedBanksRoute = BanksRoute + "/" + FailedRoute;
		private const string BankTagsRoute = TagsRoute + "/" + BanksRoute;
		private const string BankFundamentalsRoute = FundamentalsRoute + "/" + BanksRoute;
		private const string BankFinancialsRoute = FinancialsRoute + "/" + BanksRoute;
		private const string SecurityCorporateActionsRoute = SecuritiesRoute + "/" + CorporateActionsRoute;
		private const string StockExchangeCorporateActionsRoute = StockExchangesRoute + "/" + CorporateActionsRoute;
		private const string SecuritySalesSuprisesRoute = SecuritiesRoute + "/" + SuprisesRoute + "/" + SalesRoute;
		private const string SecurityEPSSuprisesRoute = SecuritiesRoute + "/" + SuprisesRoute + "/" + EPSRoute;
		private const string OptionExpirationsRoute = OptionsRoute + "/" + ExpirationsRoute;
		private const string CurrentOptionPriceRoute = OptionsRoute + "/" + CurrentRoute;
		private const string HistoricalOptionPriceRoute = OptionsRoute + "/" + HistoricalRoute;
		private const string PressReleaseContentRoute = PressReleasesRoute + "/" + DetailRoute;
		private const string ExecutiveDetailsRoute = ExecutivesRoute + "/" + DetailsRoute;
		private const string CompanyExecutiveContactsRoute = ExecutivesRoute + "/" + CompaniesRoute;
		private const string ExecutiveCompensationsRoute = ExecutivesRoute + "/" + CompensationsRoute;
		private const string ExecutiveRolesRoute = ExecutivesRoute + "/" + RolesRoute;
		private const string ValuationRouteTemplate = ValuationRoute + "/{0}";
		private const string ValuationAssumptionRouteTemplate = ValuationRoute + "/{0}/" + AssumptionsRoute;
		private const string ValuationOutputsRouteTemplate = ValuationRoute + "/{0}/" + OutputsRoute;
		private const string CompanyInsiderTransactionsRoute = CompaniesRoute + "/" + InsiderTransactionsRoute;
		private const string CompanyInsiderOwnershipRoute = CompaniesRoute + "/" + InsiderOwnershipRoute;
		private const string OwnerInsiderTransactionsRoute = OwnersRoute + "/" + InsiderTransactionsRoute;
		private const string OwnerInsiderHoldingsRoute = OwnersRoute + "/" + InsiderHoldingsRoute;
		private const string OwnerInstitutionalHoldingsRoute = OwnersRoute + "/" + InstitutionalHoldingsRoute;
		private const string SecurityInstitutionalOwnershipRoute = SecuritiesRoute + "/" + InstitutionalOwnershipRoute;

		#endregion Route Constants
	}
}