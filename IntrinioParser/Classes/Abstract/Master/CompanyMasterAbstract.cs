namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System;
	using System.Collections.Generic;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class CompanyMasterAbstract
		: BaseAbstract,
		  ICompanyMaster
	{
		internal CompanyMasterAbstract()
		{
			DataType = IntrinioDataType.Companies;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Companies = new HashSet<Company>();
		}

		#region Implementation of ICompaniesable
		[Hidden]
		public virtual ICollection<Company> Companies { get; set; }
		#endregion

		#region Implementation of ICompanyMaster
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
		#endregion
	}
}