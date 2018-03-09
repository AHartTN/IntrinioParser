namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class ExecutiveContactAbstract
		: BaseAbstract,
		  IExecutiveContact
	{
		internal ExecutiveContactAbstract()
		{
			DataType = IntrinioDataType.ExecutiveContacts;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IExecutiveContact
		[JsonProperty("")]
		public string Identifier { get; set; }

		[JsonProperty("")]
		public string Company { get; set; }

		[JsonProperty("")]
		public string JobTitle { get; set; }

		[JsonProperty("")]
		public DateTime? EffectiveDate { get; set; }

		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public string Type { get; set; }

		[JsonProperty("")]
		public string SIC { get; set; }

		[JsonProperty("")]
		public string IncorporatedCountry { get; set; }

		[JsonProperty("")]
		public string AddressLine1 { get; set; }

		[JsonProperty("")]
		public string AddressLine2 { get; set; }

		[JsonProperty("")]
		public string City { get; set; }

		[JsonProperty("")]
		public string State { get; set; }

		[JsonProperty("")]
		public string Zip { get; set; }

		[JsonProperty("")]
		public string CountryName { get; set; }

		[JsonProperty("")]
		public string MainPhone { get; set; }

		[JsonProperty("")]
		public string DirectNo { get; set; }

		[JsonProperty("")]
		public string DirectExtn { get; set; }

		[JsonProperty("")]
		public string DeptNo { get; set; }

		[JsonProperty("")]
		public string DeptExtn { get; set; }

		[JsonProperty("")]
		public string Fax { get; set; }

		[JsonProperty("")]
		public string FaxExtn { get; set; }

		[JsonProperty("")]
		public string Email { get; set; }

		[JsonProperty("")]
		public string DepartEmail { get; set; }

		[JsonProperty("")]
		public bool? LeadIndependentDirector { get; set; }

		[JsonProperty("")]
		public bool? FinanceExpertDirector { get; set; }

		[JsonProperty("")]
		public bool? IndustryExpertDirector { get; set; }

		[JsonProperty("")]
		public bool? RiskExpertDirector { get; set; }
		#endregion
	}
}