using System;
using IntrinioParser.Interfaces.Mapping.Many.Detail;

namespace IntrinioParser.Interfaces.Binding.Master
{
	public interface ICompanyMaster : ICompaniesable
	{
		string Ticker { get; set; }
		string CIK { get; set; }
		string LEI { get; set; }
		string Name { get; set; }
		DateTime? LatestFilingDate { get; set; }
	}
}