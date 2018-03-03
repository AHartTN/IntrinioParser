using System;
using IntrinioParser.Interfaces.Mapping.Many.Detail;

namespace IntrinioParser.Interfaces.Binding.Master
{
	public interface ISecurityMaster : ISecuritiesable
	{
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string SecurityName { get; set; }
		string MarketSector { get; set; }
		string SecurityType { get; set; }
		string StockExchange { get; set; }
		DateTime? LastCRSPAdjDate { get; set; }
	}
}