using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Master;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Detail;

namespace IntrinioParser.Classes.Abstract.Detail
{
	public abstract class StockExchangeAbstract : IntrinioAbstract, IStockExchange
	{
		public StockExchangeAbstract()
		{
			DataType = DataType.StockExchange;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		public int StockExchangeMasterID { get; set; }
		public StockExchangeMasterAbstract StockExchangeMaster { get; set; }
	}
}