using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	public interface ICompanyMasterable
	{
		int CompanyMasterID { get; set; }
		CompanyMasterAbstract CompanyMaster { get; set; }
	}
}