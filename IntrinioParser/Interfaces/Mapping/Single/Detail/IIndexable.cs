using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	public interface IIndexable
	{
		int IndexID { get; set; }
		IndexAbstract Index { get; set; }
	}
}