using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Many.Master
{
	public interface IOwnerMastersable
	{
		ICollection<OwnerMasterAbstract> OwnerMasters { get; set; }
	}
}