namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class InsiderOwnershipAbstract
		: BaseAbstract,
		  IInsiderOwnership
	{
		internal InsiderOwnershipAbstract()
		{
			DataType = IntrinioDataType.InsiderOwnershipByCompany;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IInsiderOwnership
		[JsonProperty("")]
		public string Identifier { get; set; }

		[JsonProperty("")]
		public string CompanyCIK { get; set; }

		[JsonProperty("")]
		public string CompanyName { get; set; }

		[JsonProperty("")]
		public string OwnerCIK { get; set; }

		[JsonProperty("")]
		public string OwnerName { get; set; }

		[JsonProperty("")]
		public DateTime? LastReportedDate { get; set; }

		[JsonProperty("")]
		public decimal? Value { get; set; }

		[JsonProperty("")]
		public decimal? Amount { get; set; }
		#endregion
	}
}