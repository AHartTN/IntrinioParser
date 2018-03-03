using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Many.Detail
{
	public interface IOwnersable
	{
		ICollection<OwnerAbstract> Owners { get; set; }
	}
}