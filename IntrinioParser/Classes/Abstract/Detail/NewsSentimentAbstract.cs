namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class NewsSentimentAbstract
		: BaseAbstract,
		  INewsSentiment
	{
		internal NewsSentimentAbstract()
		{
			DataType = IntrinioDataType.SecurityNewsSentiments;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of INewsSentiment
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
		public int? Total1W { get; set; }

		[JsonProperty("")]
		public int? Bullish1W { get; set; }

		[JsonProperty("")]
		public int? Bearish1W { get; set; }

		[JsonProperty("")]
		public int? Total4W { get; set; }

		[JsonProperty("")]
		public int? Bullish4W { get; set; }

		[JsonProperty("")]
		public int? Bearish4W { get; set; }

		[JsonProperty("")]
		public int? Total12W { get; set; }

		[JsonProperty("")]
		public int? Bullish12W { get; set; }

		[JsonProperty("")]
		public int? Bearish12W { get; set; }

		[JsonProperty("")]
		public decimal? Sentiment1W { get; set; }

		[JsonProperty("")]
		public decimal? Sentiment4W { get; set; }

		[JsonProperty("")]
		public decimal? Sentiment12W { get; set; }

		[JsonProperty("")]
		public decimal? Buzz1W4W { get; set; }

		[JsonProperty("")]
		public decimal? Buzz1W12W { get; set; }

		[JsonProperty("")]
		public decimal? Buzz4W12W { get; set; }

		[JsonProperty("")]
		public string Source { get; set; }
		#endregion
	}
}