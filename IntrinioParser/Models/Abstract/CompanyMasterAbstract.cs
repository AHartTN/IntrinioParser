using System;
using System.Collections.Generic;
using IntrinioParser.Attributes;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding;
using IntrinioParser.Models.Binding;
using Newtonsoft.Json;

namespace IntrinioParser.Models.Abstract
{
	public abstract class CompanyMasterAbstract : IntrinioAbstract, ICompanyMaster
	{
		protected CompanyMasterAbstract()
		{
			DataType = DataType.Company;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Companies = new HashSet<Company>();
		}

		[JsonProperty("ticker")]
		public string Ticker { get; set; }
		[JsonProperty("cik")]
		public string CIK { get; set; }
		[JsonProperty("lei")]
		public string LEI { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("latest_filing_date")]
		public DateTime? LatestFilingDate { get; set; }

		[Hidden]
		public ICollection<Company> Companies { get; set; }
	}
}