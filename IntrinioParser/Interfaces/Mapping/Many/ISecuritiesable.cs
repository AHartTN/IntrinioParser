using System.Collections.Generic;
using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Many
{
	public interface ISecuritiesable
	{
		ICollection<Security> Securities { get; set; }
	}
}