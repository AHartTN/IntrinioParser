namespace IntrinioParser.Mapping.CSV.Detail
{
	#region
	using CsvHelper.Configuration;

	using Models.Binding.Detail;
	#endregion

	internal sealed class OwnerCSVMap : ClassMap<Owner>
	{
		internal OwnerCSVMap()
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