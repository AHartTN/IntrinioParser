namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class ValuationAbstract
		: BaseAbstract,
		  IValuation
	{
		internal ValuationAbstract()
		{
			//DataType = IntrinioDataType;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IValuation
		[JsonProperty("")]
		public int? IntrinioID { get; set; }

		[JsonProperty("")]
		public string Status { get; set; }

		[JsonProperty("")]
		public decimal? IValue { get; set; }

		[JsonProperty("")]
		public decimal? MOSScore { get; set; }

		[JsonProperty("")]
		public DateTime? ObservedDate { get; set; }

		[JsonProperty("")]
		public int? StartYear { get; set; }

		[JsonProperty("")]
		public int? EndYear { get; set; }

		[JsonProperty("")]
		public int? FirstHistoricalYear { get; set; }

		[JsonProperty("")]
		public int? LastHistoricalYear { get; set; }

		[JsonProperty("")]
		public int? FirstProjectedYear { get; set; }

		[JsonProperty("")]
		public int? LastProjectedYear { get; set; }

		[JsonProperty("")]
		public string LastReportedFiscalQuarter { get; set; }

		[JsonProperty("")]
		public DateTime? CreatedOn { get; set; }

		[JsonProperty("")]
		public DateTime? UpdatedOn { get; set; }
		#endregion
	}
}