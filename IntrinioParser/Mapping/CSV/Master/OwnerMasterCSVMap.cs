using CsvHelper.Configuration;
using IntrinioParser.Models.Binding.Master;

namespace IntrinioParser.Mapping.CSV.Master
{
	internal sealed class OwnerMasterCSVMap : ClassMap<OwnerMaster>
	{
		public OwnerMasterCSVMap()
		{
			Map(m => m.OwnerCIK).Name("OWNER_CIK").NameIndex(0).Default(null);
			Map(m => m.OwnerName).Name("OWNER_NAME").NameIndex(0).Default(null);
		}
	}
}