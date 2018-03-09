namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;
	#endregion

	internal interface INewsSentiment
	{
		DateTime? Date { get; set; }
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string Sector { get; set; }
		int? Total1W { get; set; }
		int? Bullish1W { get; set; }
		int? Bearish1W { get; set; }
		int? Total4W { get; set; }
		int? Bullish4W { get; set; }
		int? Bearish4W { get; set; }
		int? Total12W { get; set; }
		int? Bullish12W { get; set; }
		int? Bearish12W { get; set; }
		decimal? Sentiment1W { get; set; }
		decimal? Sentiment4W { get; set; }
		decimal? Sentiment12W { get; set; }
		decimal? Buzz1W4W { get; set; }
		decimal? Buzz1W12W { get; set; }
		decimal? Buzz4W12W { get; set; }
		string Source { get; set; }
	}
}