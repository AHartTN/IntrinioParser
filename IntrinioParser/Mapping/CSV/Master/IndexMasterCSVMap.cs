namespace IntrinioParser.Mapping.CSV.Master
{
	#region
	using CsvHelper.Configuration;

	using Models.Binding.Master;
	#endregion

	internal sealed class IndexMasterCSVMap : ClassMap<IndexMaster>
	{
		internal IndexMasterCSVMap()
		{
			Map(m => m.Symbol)
				.Name("SYMBOL")
				.NameIndex(0)
				.Default(null);
			Map(m => m.IndexName)
				.Name("INDEX_NAME")
				.NameIndex(0)
				.Default(null);
		}
	}
}