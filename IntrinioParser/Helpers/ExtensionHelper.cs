namespace IntrinioParser.Helpers
{
	#region
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data;
	using System.Data.SqlClient;
	using System.IO;
	using System.Linq;
	using System.Reflection;
	using System.Security.Cryptography;
	using System.Text;
	using System.Web;

	using Attributes;

	using Classes.Abstract.Base;
	#endregion

	internal static class ExtensionHelper
	{
		internal static string BuildQueryString(this Dictionary<string, string> arguments)
		{
			if (arguments == null
				|| !arguments.Any())
				return null;

			string queryString = "?";

			IReadOnlyCollection<string> argStrings = arguments.Select(s => $"{HttpUtility.UrlEncode(s.Key)}={HttpUtility.UrlEncode(s.Value)}")
															  .ToArray();

			queryString = queryString
						  + string.Join("&",
										argStrings);

			return queryString;
		}

		internal static string Hash(this string source)
		{
			using (MD5 md5 = MD5.Create())
			{
				// Convert the input string to a byte array and compute the hash.
				byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(source));

				// Create a new Stringbuilder to collect the bytes
				// and create a string.
				StringBuilder sBuilder = new StringBuilder();

				// Loop through each byte of the hashed data 
				// and format each one as a hexadecimal string.
				foreach (byte t in data)
					sBuilder.Append(t.ToString("x2"));

				// Return the hexadecimal string.
				return sBuilder.ToString();
			}
		}

		internal static FileInfo GetFile(this string path)
		{
			if (string.IsNullOrWhiteSpace(path))
				throw new ArgumentNullException(nameof(path),
												"The path specified is empty or was null. A valid path is requried for retrieving a file.");

			FileInfo fileInfo = new FileInfo(path);

			if (fileInfo?.Directory == null)
				throw new ArgumentNullException(nameof(fileInfo),
												$"Unable to instantiate a new file info object. Get File failed for {path}");

			if (!fileInfo.Exists)
			{
				if (!fileInfo.Directory.Exists)
					fileInfo.Directory.Create();

				using (FileStream fs = fileInfo.Create())
				{
					fs.Flush();
					fs.Close();
				}
			}

			return fileInfo;
		}

		internal static FileInfo WriteFile(this string filePath,
										   string contents)
		{
			FileInfo fileInfo = filePath.GetFile();

			File.AppendAllText(fileInfo.FullName,
							   contents,
							   Encoding.UTF8);
			return fileInfo;
		}

		internal static DataTable CreateDataTable<T>(IEnumerable<T> entities)
		{
			try
			{
				Type t = typeof(T);

				PropertyInfo[] properties = t.GetProperties()
											 .Where(EventTypeFilter)
											 .ToArray();
				DataTable table = new DataTable();

				foreach (PropertyInfo property in properties)
				{
					Type propertyType = property.PropertyType;

					if (propertyType.IsGenericType
						&& propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
						propertyType = Nullable.GetUnderlyingType(propertyType);

					table.Columns.Add(new DataColumn(property.Name,
													 propertyType));
				}

				foreach (T entity in entities)
					table.Rows.Add(properties.Select(property => GetPropertyValue(property.GetValue(entity,
																									null)))
											 .ToArray());

				return table;
			}
			catch (Exception e)
			{
				Console.Error.WriteLine($"\r\n{e.Message}\r\n{e}");
				throw;
			}
		}

		private static bool EventTypeFilter(PropertyInfo p)
		{
			if (Attribute.GetCustomAttribute(p,
											 typeof(NotMappedAttribute)) is NotMappedAttribute notMappedAttribute)
				return false;

			if (Attribute.GetCustomAttribute(p,
											 typeof(HiddenAttribute)) is HiddenAttribute hiddenAttribute)
				return !hiddenAttribute.IsHidden;

			if (Attribute.GetCustomAttribute(p,
											 typeof(AssociationAttribute)) is AssociationAttribute associationAttribute)
				return associationAttribute.IsForeignKey == false;

			return true;
		}

		private static object GetPropertyValue(object o)
		{
			return o ?? DBNull.Value;
		}

		internal static void SqlBulkCopy_SqlRowsCopied(object sender,
													   SqlRowsCopiedEventArgs e)
		{
			SqlBulkCopy sbc = sender as SqlBulkCopy;

			if (sbc == null)
				return;

			Console.Write($"\r{e.RowsCopied} Rows Copied to the '{sbc.DestinationTableName}' table | Abort: {e.Abort} | Streaming: {sbc.EnableStreaming}\t\t\t\t\t\t");
		}

		private static DataTable AsDataTable<T>(this IEnumerable<T> data)
		{
			Type t = typeof(T);

			IReadOnlyCollection<PropertyInfo> properties = t.GetProperties()
															.Where(EventTypeFilter)
															.ToArray();
			DataTable table = new DataTable();

			foreach (PropertyInfo property in properties)
			{
				Type propertyType = property.PropertyType;

				if (propertyType.IsGenericType
					&& propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
					propertyType = Nullable.GetUnderlyingType(propertyType);

				table.Columns.Add(new DataColumn(property.Name,
												 propertyType));
			}

			foreach (T entity in data)
				table.Rows.Add(properties.Select(property => GetPropertyValue(property.GetValue(entity,
																								null)))
										 .ToArray());

			return table;
		}

		internal static bool WriteToDatabase<T>(this IEnumerable<T> data,
												SqlConnection conn,
												SqlBulkCopyOptions options)
			where T : BaseAbstract
		{
			T instance = Activator.CreateInstance<T>();

			if (conn.State != ConnectionState.Open)
				conn.Open();

			SqlTransaction transaction = conn.BeginTransaction();

			using (SqlBulkCopy sbc = new SqlBulkCopy(conn,
													 options,
													 transaction))
			{
				sbc.DestinationTableName = $"{instance.FullTableName}";
				try
				{
					DataTable dataTable = data.AsDataTable();
					sbc.SqlRowsCopied += SqlBulkCopy_SqlRowsCopied;
					sbc.BatchSize = 10000;
					sbc.BulkCopyTimeout = 60;

					foreach (DataColumn column in dataTable.Columns)
						sbc.ColumnMappings.Add(column.ColumnName,
											   column.ColumnName);

					sbc.WriteToServer(dataTable);
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					transaction.Rollback();
					conn.Close();
					return false;
				}
			}

			transaction.Commit();
			conn.Close();
			return true;
		}

		internal static bool IsNullOrWhiteSpace(this string source)
		{
			return string.IsNullOrWhiteSpace(source);
		}

		/// <summary>
		///     Returns a replacement string if the source string is null, empty, or contains nothing but whtiespace characters
		/// </summary>
		/// <param name="source">The source string to check against</param>
		/// <param name="replacement">The replacement string should the check come back true</param>
		/// <returns>The replacement string if true, otherwise the source string</returns>
		internal static string IfNullOrWhiteSpace(this string source,
												  string replacement)
		{
			if (string.IsNullOrWhiteSpace(source))
				return replacement;

			return source;
		}

		/// <summary>
		///     Returns a replacement string if the source string is equal to any of the specified strings
		/// </summary>
		/// <param name="source">The source string to check against</param>
		/// <param name="replacement">The replacement string should the check come back true</param>
		/// <param name="input">The values to compare the source string against</param>
		/// <returns>The replacement string if the source string equals any of the input strings, otherwise the source string</returns>
		internal static string IfEquals(this string source,
										string[] input,
										string replacement)
		{
			if (input.Any(a => a.Equals(source)))
				return replacement;

			return source;
		}

		/// <summary>
		///     Converts a string into a nullable integer
		/// </summary>
		/// <param name="source">The source string containing the number</param>
		/// <returns>An integer representing the source string</returns>
		internal static int? ToNullableInt(this string source)
		{
			int? result;
			if (string.IsNullOrWhiteSpace(source))
			{
				result = null;
			}
			else
			{
				if (int.TryParse(source,
								 out int j))
					result = j;
				else
					result = null;
			}

			return result;
		}

		/// <summary>
		///     Converts a string decimalo a nullable decimaleger
		/// </summary>
		/// <param name="source">The source string containing the number</param>
		/// <returns>An decimaleger representing the source string</returns>
		internal static decimal? ToNullableDecimal(this string source)
		{
			decimal? result;
			if (string.IsNullOrWhiteSpace(source))
			{
				result = null;
			}
			else
			{
				if (decimal.TryParse(source,
									 out decimal j))
					result = j;
				else
					result = null;
			}

			return result;
		}
	}
}