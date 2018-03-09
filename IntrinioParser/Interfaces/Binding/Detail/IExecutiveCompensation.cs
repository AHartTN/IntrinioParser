namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;
	#endregion

	internal interface IExecutiveCompensation : IBaseModel
	{
		string JobTitle { get; set; }
		string Company { get; set; }
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		int? CompensationYear { get; set; }
		int? ProxyYear { get; set; }
		DateTime? MeetingDate { get; set; }
		decimal? CashPaid { get; set; }
		decimal? Salary { get; set; }
		decimal? Bonus { get; set; }
		decimal? StockAwards { get; set; }
		decimal? OptionAwards { get; set; }
		decimal? PensionNQDC { get; set; }
		decimal? NonEqtyIncecntivePlan { get; set; }
		decimal? AllOtherCopmpensation { get; set; }
		decimal? TotalSummary { get; set; }
		CurrencyDenomination? CurrencyDenomination { get; set; }
		string Currency { get; set; }
		bool? DirectorCompensation { get; set; }
	}
}