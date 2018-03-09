namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class BloggerRatingAbstract
		: BaseAbstract,
		  IBloggerRating
	{
		internal BloggerRatingAbstract()
		{
			DataType = IntrinioDataType.BloggerRatings;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IBloggerRating
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
		public int? BlogID { get; set; }

		[JsonProperty("")]
		public int? BloggerID { get; set; }

		[JsonProperty("")]
		public RecommendationRating Rating { get; set; }

		[JsonProperty("")]
		public string Source { get; set; }
		#endregion
	}
}