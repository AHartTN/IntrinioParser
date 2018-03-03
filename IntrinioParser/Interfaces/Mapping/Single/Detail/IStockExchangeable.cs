using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	public interface IStockExchangeable
	{
		int StockExchangeID { get; set; }
		StockExchangeAbstract StockExchange { get; set; }
	}
}