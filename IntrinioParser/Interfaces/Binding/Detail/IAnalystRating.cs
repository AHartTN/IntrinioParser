namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;
	#endregion

	internal interface IAnalystRating : IBaseModel
	{
		DateTime? Date { get; set; }
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string Sector { get; set; }
		int? AnalystIntrinioID { get; set; }
		int? AnalystFirmIntrinioID { get; set; }
		string AnalystFirmName { get; set; }
		AnalystAction Action { get; set; }
		RecommendationRating Rating { get; set; }
		decimal? PriceTarget { get; set; }
		string Source { get; set; }
	}
}