namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class AnalystRatingAbstract
		: BaseAbstract,
		  IAnalystRating
	{
		internal AnalystRatingAbstract()
		{
			DataType = IntrinioDataType.AnalystRatings;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IAnalystRating
		[JsonProperty("")]
		public DateTime? Date { get; set; }

		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public string Sector { get; set; }

		[JsonProperty("")]
		public int? AnalystIntrinioID { get; set; }

		[JsonProperty("")]
		public int? AnalystFirmIntrinioID { get; set; }

		[JsonProperty("")]
		public string AnalystFirmName { get; set; }

		[JsonProperty("")]
		public AnalystAction Action { get; set; }

		[JsonProperty("")]
		public RecommendationRating Rating { get; set; }

		[JsonProperty("")]
		public decimal? PriceTarget { get; set; }

		[JsonProperty("")]
		public string Source { get; set; }
		#endregion
	}
}