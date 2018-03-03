using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	public interface ISecurityable
	{
		int SecurityID { get; set; }
		SecurityAbstract Security { get; set; }
	}
}