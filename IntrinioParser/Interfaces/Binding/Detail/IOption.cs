namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IOption : IBaseModel
	{
		DateTime? Date { get; set; }
		DateTime? Expiration { get; set; }
		decimal? Strike { get; set; }
		string Type { get; set; }
		decimal? Close { get; set; }
		decimal? CloseBid { get; set; }
		decimal? CloseAsk { get; set; }
		decimal? Volume { get; set; }
		decimal? VolumeBid { get; set; }
		decimal? VolumeAsk { get; set; }
		decimal? Trades { get; set; }
		decimal? OpenInterest { get; set; }
		decimal? OpenInterestChange { get; set; }
		decimal? NextDayOpenInterest { get; set; }
		decimal? ImpliedVolatility { get; set; }
		decimal? ImpliedVolatilityChange { get; set; }
		decimal? Delta { get; set; }
	}
}