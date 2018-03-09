namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;

	using Newtonsoft.Json;
	#endregion

	internal abstract class CompanyAbstract
		: BaseAbstract,
		  ICompany
	{
		internal CompanyAbstract()
		{
			DataType = IntrinioDataType.Companies;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ICompanyMasterable
		public int CompanyMasterID { get; set; }
		public CompanyMaster CompanyMaster { get; set; }
		#endregion

		#region Implementation of ICompany
		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string CIK { get; set; }

		[JsonProperty("")]
		public string Name { get; set; }

		[JsonProperty("")]
		public string LegalName { get; set; }

		[JsonProperty("")]
		public string LEI { get; set; }

		[JsonProperty("")]
		public string HQAddress1 { get; set; }

		[JsonProperty("")]
		public string HQAddress2 { get; set; }

		[JsonProperty("")]
		public string HQAddressCity { get; set; }

		[JsonProperty("")]
		public string HQAddressPostalCode { get; set; }

		[JsonProperty("")]
		public string EntityLegalForm { get; set; }

		[JsonProperty("")]
		public string HQState { get; set; }

		[JsonProperty("")]
		public string HQCountry { get; set; }

		[JsonProperty("")]
		public string IncState { get; set; }

		[JsonProperty("")]
		public string IncCountry { get; set; }

		[JsonProperty("")]
		public string SIC { get; set; }

		[JsonProperty("")]
		public string StockExchange { get; set; }

		[JsonProperty("")]
		public string Template { get; set; }

		[JsonProperty("")]
		public string ShortDescription { get; set; }

		[JsonProperty("")]
		public string LongDescription { get; set; }

		[JsonProperty("")]
		public string CEO { get; set; }

		[JsonProperty("")]
		public string CompanyURL { get; set; }

		[JsonProperty("")]
		public string BusinessAddress { get; set; }

		[JsonProperty("")]
		public string MailingAddress { get; set; }

		[JsonProperty("")]
		public string BusinessPhoneNo { get; set; }

		[JsonProperty("")]
		public int? Employees { get; set; }

		[JsonProperty("")]
		public string Sector { get; set; }

		[JsonProperty("")]
		public string IndustryCategory { get; set; }

		[JsonProperty("")]
		public string IndustryGroup { get; set; }

		[JsonProperty("")]
		public bool? StandardizedActive { get; set; }
		#endregion
	}
}