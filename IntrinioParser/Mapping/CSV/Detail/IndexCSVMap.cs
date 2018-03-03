using CsvHelper.Configuration;
using IntrinioParser.Models.Binding.Detail;

namespace IntrinioParser.Mapping.CSV.Detail
{
	internal sealed class IndexCSVMap : ClassMap<Index>
	{
		public IndexCSVMap()
		{
			Map(p => p.Symbol).Name("SYMBOL").NameIndex(0).Default(null);
			Map(p => p.IndexName).Name("INDEX_NAME").NameIndex(0).Default(null);
			Map(p => p.IndexType).Name("INDEX_TYPE").NameIndex(0).Default(null);
			Map(p => p.Continent).Name("CONTINENT").NameIndex(0).Default(null);
			Map(p => p.Country).Name("COUNTRY").NameIndex(0).Default(null);
			Map(p => p.FredSymbol).Name("FRED_SYMBOL").NameIndex(0).Default(null);
			Map(p => p.UpdateFrequency).Name("UPDATE_FREQUENCY").NameIndex(0).Default(null);
			Map(p => p.LastUpdated).Name("LAST_UPDATED").NameIndex(0).Default(null);
			Map(p => p.ObservationStart).Name("OBSERVATION_START").NameIndex(0).Default(null);
			Map(p => p.ObservationEnd).Name("OBSERVATION_END").NameIndex(0).Default(null);
			Map(p => p.Popularity).Name("POPULARITY").NameIndex(0).Default(null);
			Map(p => p.SeasonalAdjustment).Name("SEASONAL_ADJUSTMENT").NameIndex(0).Default(null);
			Map(p => p.SeasonalAdjustmentShort).Name("SEASONAL_ADJUSTMENT_SHORT").NameIndex(0).Default(null);
			Map(p => p.Units).Name("UNITS").NameIndex(0).Default(null);
			Map(p => p.UnitsShort).Name("UNITS_SHORT").NameIndex(0).Default(null);
		}
	}
}