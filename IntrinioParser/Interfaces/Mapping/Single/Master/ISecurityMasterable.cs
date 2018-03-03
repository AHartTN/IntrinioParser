using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	public interface ISecurityMasterable
	{
		int SecurityMasterID { get; set; }
		SecurityMasterAbstract SecurityMaster { get; set; }
	}
}