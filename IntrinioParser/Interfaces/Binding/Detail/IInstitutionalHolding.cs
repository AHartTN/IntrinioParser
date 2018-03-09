namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IInstitutionalHolding : IBaseModel
	{
		string CUSIP { get; set; }
		string Ticker { get; set; }
		string SecurityName { get; set; }
		string SecurityType { get; set; }
		string TitleOfClass { get; set; }
		string StockExchange { get; set; }
		DateTime? PeriodEnded { get; set; }
		decimal? Value { get; set; }
		decimal? Amount { get; set; }
		string Type { get; set; }
		string InvestmentDiscretion { get; set; }
		string OtherManager { get; set; }
		decimal? SoleVotingAuthority { get; set; }
		decimal? SharedVotingAuthority { get; set; }
		decimal? NoVotingAuthority { get; set; }
	}
}