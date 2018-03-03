using IntrinioParser.Interfaces.Mapping.Many.Detail;

namespace IntrinioParser.Interfaces.Binding.Master
{
	public interface IOwnerMaster : IOwnersable
	{
		string OwnerCIK { get; set; }
		string OwnerName { get; set; }
	}
}