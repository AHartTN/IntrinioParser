using IntrinioParser.Interfaces.Mapping.Many.Detail;

namespace IntrinioParser.Interfaces.Binding.Master
{
	public interface IIndexMaster : IIndicesable
	{
		string Symbol { get; set; }
		string IndexName { get; set; }
	}
}