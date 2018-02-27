using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Single
{
	public interface ICompanyable
	{
		int CompanyID { get; set; }
		Company Company { get; set; }
	}
}