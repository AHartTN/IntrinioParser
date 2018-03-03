using System;
using System.Collections.Generic;
using IntrinioParser.Attributes;
using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Detail;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Master;
using Newtonsoft.Json;

namespace IntrinioParser.Classes.Abstract.Master
{
	public abstract class CompanyMasterAbstract : IntrinioAbstract, ICompanyMaster
	{
		public CompanyMasterAbstract()
		{
			DataType = DataType.Company;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Companies = new HashSet<CompanyAbstract>();
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
		public ICollection<CompanyAbstract> Companies { get; set; }
	}
}