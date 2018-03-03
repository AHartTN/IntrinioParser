using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Many.Detail
{
	public interface ISecuritiesable
	{
		ICollection<SecurityAbstract> Securities { get; set; }
	}
}