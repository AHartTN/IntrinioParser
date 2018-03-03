using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	public interface ICompanyable
	{
		int CompanyID { get; set; }
		CompanyAbstract Company { get; set; }
	}
}