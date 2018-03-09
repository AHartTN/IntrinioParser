namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;
	using System.Collections.Generic;

	using Enumerators;

	using Models.Binding.Detail;
	#endregion

	internal interface IBankBranch
	{
		int? RSSDID { get; set; }
		string BankName { get; set; }
		int? UniNumber { get; set; }
		int? BranchNumber { get; set; }
		string BranchName { get; set; }
		string Address { get; set; }
		string City { get; set; }
		string State { get; set; }
		string ZipCode { get; set; }

		string County { get; set; }
		string Country { get; set; }
		int? StateNo { get; set; }
		int? StateAndCountyNo { get; set; }
		string CentralCity { get; set; }
		decimal? Latitude { get; set; }
		decimal? Longitude { get; set; }
		string LocationQuality { get; set; }
		string LocationMethod { get; set; }
		int? PlaceNum { get; set; }
		BranchServiceType BranchServiceType { get; set; }
		bool? MainOffice { get; set; }
		int? MSANo { get; set; }
		string MSA { get; set; }
		int? CSANo { get; set; }
		string CSA { get; set; }
		int? CBSANo { get; set; }
		string CBSA { get; set; }
		int? CBSADivisionNo { get; set; }
		string CBSADivision { get; set; }
		DateTime? EstablishedOn { get; set; }
		DateTime? AcquiredOn { get; set; }
		ICollection<BankDeposit> Deposits { get; set; }
	}
}