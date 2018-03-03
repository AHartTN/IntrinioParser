using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	public interface IOwnerable
	{
		int OwnerID { get; set; }
		OwnerAbstract Owner { get; set; }
	}
}