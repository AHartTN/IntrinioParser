namespace IntrinioParser.Mapping.CSV.Master
{
	#region
	using CsvHelper.Configuration;

	using Models.Binding.Master;
	#endregion

	internal sealed class OwnerMasterCSVMap : ClassMap<OwnerMaster>
	{
		internal OwnerMasterCSVMap()
		{
			Map(m => m.OwnerCIK)
				.Name("OWNER_CIK")
				.NameIndex(0)
				.Default(null);
			Map(m => m.OwnerName)
				.Name("OWNER_NAME")
				.NameIndex(0)
				.Default(null);
		}
	}
}