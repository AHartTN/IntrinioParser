namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class ExecutiveCompensationAbstract
		: BaseAbstract,
		  IExecutiveCompensation
	{
		internal ExecutiveCompensationAbstract()
		{
			DataType = IntrinioDataType.ExecutiveCompensation;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IExecutiveCompensation
		[JsonProperty("")]
		public string JobTitle { get; set; }

		[JsonProperty("")]
		public string Company { get; set; }

		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public int? CompensationYear { get; set; }

		[JsonProperty("")]
		public int? ProxyYear { get; set; }

		[JsonProperty("")]
		public DateTime? MeetingDate { get; set; }

		[JsonProperty("")]
		public decimal? CashPaid { get; set; }

		[JsonProperty("")]
		public decimal? Salary { get; set; }

		[JsonProperty("")]
		public decimal? Bonus { get; set; }

		[JsonProperty("")]
		public decimal? StockAwards { get; set; }

		[JsonProperty("")]
		public decimal? OptionAwards { get; set; }

		[JsonProperty("")]
		public decimal? PensionNQDC { get; set; }

		[JsonProperty("")]
		public decimal? NonEqtyIncecntivePlan { get; set; }

		[JsonProperty("")]
		public decimal? AllOtherCopmpensation { get; set; }

		[JsonProperty("")]
		public decimal? TotalSummary { get; set; }

		[JsonProperty("")]
		public CurrencyDenomination? CurrencyDenomination { get; set; }

		[JsonProperty("")]
		public string Currency { get; set; }

		[JsonProperty("")]
		public bool? DirectorCompensation { get; set; }
		#endregion
	}
}