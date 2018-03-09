namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IPrices : IBaseModel
	{
		DateTime? Date { get; set; }
		decimal? Open { get; set; }
		decimal? High { get; set; }
		decimal? Low { get; set; }
		decimal? Close { get; set; }
		long Volume { get; set; }
		decimal? ExDividend { get; set; }
		decimal? SplitRatio { get; set; }
		decimal? AdjOpen { get; set; }
		decimal? AdjHigh { get; set; }
		decimal? AdjLow { get; set; }
		decimal? AdjClose { get; set; }
		long AdjVolume { get; set; }
	}
}