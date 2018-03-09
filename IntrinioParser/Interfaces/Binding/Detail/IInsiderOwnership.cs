namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IInsiderOwnership : IBaseModel
	{
		string Identifier { get; set; }
		string CompanyCIK { get; set; }
		string CompanyName { get; set; }
		string OwnerCIK { get; set; }
		string OwnerName { get; set; }
		DateTime? LastReportedDate { get; set; }
		decimal? Value { get; set; }
		decimal? Amount { get; set; }
	}
}