using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Single
{
	public interface ISecurityMasterable
	{
		int SecurityMasterID { get; set; }
		SecurityMaster SecurityMaster { get; set; }
	}
}