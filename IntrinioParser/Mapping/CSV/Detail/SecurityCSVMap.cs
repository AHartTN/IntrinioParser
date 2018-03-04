namespace IntrinioParser.Mapping.CSV.Detail
{
	#region
	using CsvHelper.Configuration;

	using Models.Binding.Detail;
	#endregion

	internal sealed class SecurityCSVMap : ClassMap<Security>
	{
		internal SecurityCSVMap()
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
			Map(m => m.CompositeFIGI)
				.Name("COMPOSITE_FIGI")
				.NameIndex(0)
				.Default(null);
			Map(m => m.CompositeFIGITicker)
				.Name("COMPOSITE_FIGI_TICKER")
				.NameIndex(0)
				.Default(null);
			Map(m => m.FIGIUniqueID)
				.Name("FIGI_UNIQUEID")
				.NameIndex(0)
				.Default(null);
			Map(m => m.ShareClassFIGI)
				.Name("SHARE_CLASS_FIGI")
				.NameIndex(0)
				.Default(null);
			Map(m => m.FIGIExchCntry)
				.Name("FIGI_EXCH_CNTRY")
				.NameIndex(0)
				.Default(null);
			Map(m => m.Currency)
				.Name("CURRENCY")
				.NameIndex(0)
				.Default(null);
			Map(m => m.MIC)
				.Name("MIC")
				.NameIndex(0)
				.Default(null);
			Map(m => m.ExchSymbol)
				.Name("EXCH_SYMBOL")
				.NameIndex(0)
				.Default(null);
			Map(m => m.ETF)
				.Name("ETF")
				.NameIndex(0);
			Map(m => m.DelistedSecurity)
				.Name("DELISTED_SECURITY")
				.NameIndex(0);
			Map(m => m.PrimaryListing)
				.Name("PRIMARY_LISTING")
				.NameIndex(0);
		}
	}
}