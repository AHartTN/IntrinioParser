using CsvHelper.Configuration;
using IntrinioParser.Models.Binding;

namespace IntrinioParser.Models.Mapping.CSV
{
	public sealed class CompanyMasterCSVMap : ClassMap<CompanyMaster>
	{
		public CompanyMasterCSVMap()
		{
			Map(m => m.Ticker)
				.Name("TICKER")
				.NameIndex(0)
				.Default(null);
			Map(m => m.CIK)
				.Name("CIK")
				.NameIndex(0)
				.Default(null);
			Map(m => m.LEI)
				.Name("LEI")
				.NameIndex(0)
				.Default(null);
			Map(m => m.Name)
				.Name("NAME")
				.NameIndex(0)
				.Default(null);
			Map(m => m.LatestFilingDate)
				.Name("LATEST_FILING_DATE")
				.NameIndex(0);
		}
	}
}