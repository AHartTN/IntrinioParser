namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;
	#endregion

	internal interface IFailedBank : IBaseModel
	{
		int? FINID { get; set; }
		string Name { get; set; }
		string City { get; set; }
		string State { get; set; }
		DateTime? EffectiveDate { get; set; }
		string InsuranceFund { get; set; }
		string TransactionType { get; set; }
		BankClass? CharterClass { get; set; }
		string FailedOrAssistance { get; set; }
		decimal? TotalDeposits { get; set; }
		decimal? TotalAssets { get; set; }
		decimal? EstimatedFDICLoss { get; set; }
	}
}