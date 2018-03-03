using CsvHelper.Configuration;
using IntrinioParser.Models.Binding.Master;

namespace IntrinioParser.Mapping.CSV.Master
{
	internal sealed class IndexMasterCSVMap : ClassMap<IndexMaster>
	{
		public IndexMasterCSVMap()
		{
			Map(m => m.Symbol).Name("SYMBOL").NameIndex(0).Default(null);
			Map(m => m.IndexName).Name("INDEX_NAME").NameIndex(0).Default(null);
		}
	}
}