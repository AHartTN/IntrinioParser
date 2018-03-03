using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	public interface IIndexMasterable
	{
		int IndexMasterID { get; set; }
		IndexMasterAbstract IndexMaster { get; set; }
	}
}