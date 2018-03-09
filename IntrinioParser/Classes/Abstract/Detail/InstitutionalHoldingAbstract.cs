namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class InstitutionalHoldingAbstract
		: BaseAbstract,
		  IInstitutionalHolding
	{
		internal InstitutionalHoldingAbstract()
		{
			DataType = IntrinioDataType.InstitutionalHoldingsByOwner;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IInstitutionalHolding
		[JsonProperty("")]
		public string CUSIP { get; set; }

		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string SecurityName { get; set; }

		[JsonProperty("")]
		public string SecurityType { get; set; }

		[JsonProperty("")]
		public string TitleOfClass { get; set; }

		[JsonProperty("")]
		public string StockExchange { get; set; }

		[JsonProperty("")]
		public DateTime? PeriodEnded { get; set; }

		[JsonProperty("")]
		public decimal? Value { get; set; }

		[JsonProperty("")]
		public decimal? Amount { get; set; }

		[JsonProperty("")]
		public string Type { get; set; }

		[JsonProperty("")]
		public string InvestmentDiscretion { get; set; }

		[JsonProperty("")]
		public string OtherManager { get; set; }

		[JsonProperty("")]
		public decimal? SoleVotingAuthority { get; set; }

		[JsonProperty("")]
		public decimal? SharedVotingAuthority { get; set; }

		[JsonProperty("")]
		public decimal? NoVotingAuthority { get; set; }
		#endregion
	}
}