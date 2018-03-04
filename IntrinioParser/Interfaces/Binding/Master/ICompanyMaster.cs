namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using System;

	using Base;

	using Mapping.Many.Detail;
	#endregion

	internal interface ICompanyMaster
		: IBaseModel,
		  ICompaniesable
	{
		string Ticker { get; set; }
		string CIK { get; set; }
		string LEI { get; set; }
		string Name { get; set; }
		DateTime? LatestFilingDate { get; set; }
	}
}