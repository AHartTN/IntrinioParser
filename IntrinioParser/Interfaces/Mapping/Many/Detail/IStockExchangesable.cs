using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Detail;

namespace IntrinioParser.Interfaces.Mapping.Many.Detail
{
	public interface IStockExchangesable
	{
		IReadOnlyCollection<StockExchangeAbstract> StockExchanges { get; set; }
	}
}