using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Single
{
	public interface ICompanyMasterable
	{
		int CompanyMasterID { get; set; }
		CompanyMaster CompanyMaster { get; set; }
	}
}