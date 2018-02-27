using System.Collections.Generic;
using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Many
{
	public interface ISecurityMastersable
	{
		ICollection<SecurityMaster> SecurityMasters { get; set; }
	}
}