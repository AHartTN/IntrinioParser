using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	public interface IOwnerMasterable
	{
		int OwnerMasterID { get; set; }
		OwnerMasterAbstract OwnerMaster { get; set; }
	}
}