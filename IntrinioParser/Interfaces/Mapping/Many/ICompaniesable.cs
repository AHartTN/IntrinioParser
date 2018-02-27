using System.Collections.Generic;
using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Many
{
	public interface ICompaniesable
	{
		ICollection<Company> Companies { get; set; }
	}
}