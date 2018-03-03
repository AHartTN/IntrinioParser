using IntrinioParser.Classes.Abstract.Master;

namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	public interface IStockExchangeMasterable
	{
		int StockExchangeMasterID { get; set; }
		StockExchangeMasterAbstract StockExchangeMaster { get; set; }
	}
}