using System.Collections.Generic;
using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Many
{
	public interface ICompanyMastersable
	{
		ICollection<CompanyMaster> CompanyMasters { get; set; }
	}
}