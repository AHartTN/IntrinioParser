namespace IntrinioParser.Mapping.CSV.Master
{
	#region
	using CsvHelper.Configuration;

	using Models.Binding.Master;
	#endregion

	internal sealed class SecurityMasterCSVMap : ClassMap<SecurityMaster>
	{
		internal SecurityMasterCSVMap()
		{
			Map(m => m.Ticker)
				.Name("TICKER")
				.NameIndex(0)
				.Default(null);
			Map(m => m.FIGITicker)
				.Name("FIGI_TICKER")
				.NameIndex(0)
				.Default(null);
			Map(m => m.FIGI)
				.Name("FIGI")
				.NameIndex(0)
				.Default(null);
			Map(m => m.SecurityName)
				.Name("SECURITY_NAME")
				.NameIndex(0)
				.Default(null);
			Map(m => m.MarketSector)
				.Name("MARKET_SECTOR")
				.NameIndex(0)
				.Default(null);
			Map(m => m.SecurityType)
				.Name("SECURITY_TYPE")
				.NameIndex(0)
				.Default(null);
			Map(m => m.StockExchange)
				.Name("STOCK_EXCHANGE")
				.NameIndex(0)
				.Default(null);
			Map(m => m.LastCRSPAdjDate)
				.Name("LAST_CRSP_ADJ_DATE")
				.NameIndex(0);
		}
	}
}