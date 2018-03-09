namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IExecutiveContact : IBaseModel
	{
		string Identifier { get; set; }
		string Company { get; set; }
		string JobTitle { get; set; }
		DateTime? EffectiveDate { get; set; }
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string Type { get; set; }
		string SIC { get; set; }
		string IncorporatedCountry { get; set; }
		string AddressLine1 { get; set; }
		string AddressLine2 { get; set; }
		string City { get; set; }
		string State { get; set; }
		string Zip { get; set; }
		string CountryName { get; set; }
		string MainPhone { get; set; }
		string DirectNo { get; set; }
		string DirectExtn { get; set; }
		string DeptNo { get; set; }
		string DeptExtn { get; set; }
		string Fax { get; set; }
		string FaxExtn { get; set; }
		string Email { get; set; }
		string DepartEmail { get; set; }
		bool? LeadIndependentDirector { get; set; }
		bool? FinanceExpertDirector { get; set; }
		bool? IndustryExpertDirector { get; set; }
		bool? RiskExpertDirector { get; set; }
	}
}