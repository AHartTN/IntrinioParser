using IntrinioParser.Models.Binding;

namespace IntrinioParser.Interfaces.Mapping.Single
{
	public interface ISecurityable
	{
		int SecurityID { get; set; }
		Security Security { get; set; }
	}
}