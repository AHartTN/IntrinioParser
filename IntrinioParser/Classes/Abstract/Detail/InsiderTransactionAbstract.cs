namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class InsiderTransactionAbstract
		: BaseAbstract,
		  IInsiderTransaction
	{
		internal InsiderTransactionAbstract()
		{
			DataType = IntrinioDataType.InsiderTransactionsByCompany;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IInsiderTransaction
		[JsonProperty("")]
		public string Identifier { get; set; }

		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string CompanyCIK { get; set; }

		[JsonProperty("")]
		public string CompanyName { get; set; }

		[JsonProperty("")]
		public string OwnerCIK { get; set; }

		[JsonProperty("")]
		public string OwnerName { get; set; }

		[JsonProperty("")]
		public DateTime? FilingDate { get; set; }

		[JsonProperty("")]
		public string FilingUrl { get; set; }

		[JsonProperty("")]
		public bool? Director { get; set; }

		[JsonProperty("")]
		public bool? Officer { get; set; }

		[JsonProperty("")]
		public bool? TenPercentOwner { get; set; }

		[JsonProperty("")]
		public bool? OtherRelation { get; set; }

		[JsonProperty("")]
		public string OfficerTitle { get; set; }

		[JsonProperty("")]
		public bool? DerivativeTransaction { get; set; }

		[JsonProperty("")]
		public string SecurityTitle { get; set; }

		[JsonProperty("")]
		public DateTime? TransactionDate { get; set; }

		[JsonProperty("")]
		public DateTime? DeemedExecutionDate { get; set; }

		[JsonProperty("")]
		public string TransactionTypeCode { get; set; }

		[JsonProperty("")]
		public decimal? AmountOfShares { get; set; }

		[JsonProperty("")]
		public string AcquisitionDispositionCode { get; set; }

		[JsonProperty("")]
		public decimal? TransactionPrice { get; set; }

		[JsonProperty("")]
		public decimal? TotalSharesOwned { get; set; }

		[JsonProperty("")]
		public string OwnershipTypeCode { get; set; }

		[JsonProperty("")]
		public string NatureOfOwnership { get; set; }

		[JsonProperty("")]
		public int? ReportLineNumber { get; set; }

		[JsonProperty("")]
		public decimal? ConversionExercisePrice { get; set; }

		[JsonProperty("")]
		public DateTime? ExerciseDate { get; set; }

		[JsonProperty("")]
		public string UnderlyingSecurityTitle { get; set; }

		[JsonProperty("")]
		public decimal? UnderlyingShares { get; set; }
		#endregion
	}
}