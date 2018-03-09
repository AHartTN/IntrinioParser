namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class SurpriseAbstract
		: BaseAbstract,
		  ISurprise
	{
		internal SurpriseAbstract()
		{
			//DataType = IntrinioDataType;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ISurprise
		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public int? FiscalYear { get; set; }

		[JsonProperty("")]
		public string FiscalQuarter { get; set; }

		[JsonProperty("")]
		public int? CalendarYear { get; set; }

		[JsonProperty("")]
		public string CalendarQuarter { get; set; }

		[JsonProperty("")]
		public DateTime? ActualReportedDate { get; set; }

		[JsonProperty("")]
		public string ActualReportedTime { get; set; }

		[JsonProperty("")]
		public string ActualReportedCode { get; set; }

		[JsonProperty("")]
		public string ActualReportedDesc { get; set; }
		#endregion
	}
}