using System;
using IntrinioParser.Interfaces.Mapping.Many;

namespace IntrinioParser.Interfaces.Binding
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