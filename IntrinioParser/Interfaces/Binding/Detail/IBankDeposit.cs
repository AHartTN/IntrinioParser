namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;

	using Models.Binding.Detail;
	#endregion

	internal interface IBankDeposit : IBaseModel
	{
		int BankBranchID { get; set; }
		DateTime? ReportedDate { get; set; }
		int? Year { get; set; }
		decimal? TotalDeposits { get; set; }
		BankBranch BankBranch { get; set; }
	}
}