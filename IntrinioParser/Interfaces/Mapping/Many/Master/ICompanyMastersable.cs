using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Many.Master
{
	public interface ICompanyMastersable
	{
		ICollection<CompanyMasterAbstract> CompanyMasters { get; set; }
	}
}