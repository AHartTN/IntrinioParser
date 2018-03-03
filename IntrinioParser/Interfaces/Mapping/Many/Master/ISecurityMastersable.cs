using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Many.Master
{
	public interface ISecurityMastersable
	{
		ICollection<SecurityMasterAbstract> SecurityMasters { get; set; }
	}
}