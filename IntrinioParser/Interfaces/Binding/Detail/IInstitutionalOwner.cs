namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IInstitutionalOwner : IBaseModel
	{
		string OwnerCIK { get; set; }
		string OwnerName { get; set; }
		DateTime? PeriodEnded { get; set; }
		decimal? Value { get; set; }
		decimal? Amount { get; set; }
		decimal? SoleVotingAuthority { get; set; }
		decimal? SharedVotingAuthority { get; set; }
		decimal? NoVotingAuthority { get; set; }
		decimal? PrevAmount { get; set; }
		decimal? AmountChg { get; set; }
		decimal? AmountPctChg { get; set; }
	}
}