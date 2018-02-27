using System;
using IntrinioParser.Interfaces.Mapping.Single;

namespace IntrinioParser.Interfaces.Binding
{
	public interface ISecurity : ISecurityMasterable
	{
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string SecurityName { get; set; }
		string MarketSector { get; set; }
		string SecurityType { get; set; }
		string StockExchange { get; set; }
		DateTime? LastCRSPAdjDate { get; set; }
		string CompositeFIGI { get; set; }
		string CompositeFIGITicker { get; set; }
		string FIGIUniqueID { get; set; }
		string ShareClassFIGI { get; set; }
		string FIGIExchCntry { get; set; }
		string Currency { get; set; }
		string MIC { get; set; }
		string ExchSymbol { get; set; }
		bool? ETF { get; set; }
		bool? DelistedSecurity { get; set; }
		bool? PrimaryListing { get; set; }
	}
}