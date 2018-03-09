namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Models.Binding.Detail;
	#endregion

	internal interface IBank : IBaseModel
	{
		string RSSDID { get; set; }
		string Name { get; set; }
		string FDICCertificateNumber { get; set; }
		bool? Form31Filter { get; set; }
		string Address { get; set; }
		string City { get; set; }
		string State { get; set; }
		string ZipCode { get; set; }
		string County { get; set; }
		string StateAndCountyNo { get; set; }
		int? StateNo { get; set; }
		string Url { get; set; }
		int? TotalBranches { get; set; }
		int? DomesticBranches { get; set; }
		int? ForeignBranches { get; set; }
		string AssetConcentration { get; set; }
		AssetConcentration? AssetConcentrationNo { get; set; }
		int? OCCCharterNumber { get; set; }
		int? FDICGeoRegionNo { get; set; }
		string FDICSupervisoryRegion { get; set; }
		int? FDICSupervisoryRegionNo { get; set; }
		string FRBDistrict { get; set; }
		FRBDistrict? FRBDistrictNo { get; set; }
		int? OTSDistrictNo { get; set; }
		string OTSDistrict { get; set; }
		int? OCCDistrictNo { get; set; }
		string Regulator { get; set; }
		bool? StateCharter { get; set; }
		bool? FederalCharter { get; set; }
		string FDICFieldOffice { get; set; }
		BankClass BankClass { get; set; }
		string CharteringAgency { get; set; }
		bool? Conservatorship { get; set; }
		bool? InterstateBranches { get; set; }
		bool? SCorp { get; set; }
		bool? TrustFiduciaryServices { get; set; }
		bool? CommunityBank { get; set; }
		int? CMSANo { get; set; }
		string CMSA { get; set; }
		int? MSANo { get; set; }
		string MSA { get; set; }
		int? CSANo { get; set; }
		string CSA { get; set; }
		int? CBSANo { get; set; }
		string CBSA { get; set; }
		int? CBSAMetroNo { get; set; }
		string CBSAMetro { get; set; }
		int? CBSADivisionNo { get; set; }
		string CBSADivision { get; set; }
		DateTime? LastUpdate { get; set; }
		DateTime? LastStructuralChange { get; set; }
		DateTime? EstablishedDate { get; set; }
		DateTime? DepositInsuranceDate { get; set; }
		bool? Active { get; set; }
		ICollection<BankHolding> BankHolding { get; set; }
	}
}