using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Many.Detail
{
	public interface IIndicesable
	{
		ICollection<IndexAbstract> Indices { get; set; }
	}
}