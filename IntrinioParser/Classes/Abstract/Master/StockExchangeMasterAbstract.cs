using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Detail;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Master;

namespace IntrinioParser.Classes.Abstract.Master
{
	public abstract class StockExchangeMasterAbstract : IntrinioAbstract, IStockExchangeMaster
	{
		public StockExchangeMasterAbstract()
		{
			DataType = DataType.StockExchange;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			StockExchanges = new HashSet<StockExchangeAbstract>();
		}

		public string Symbol { get; set; }
		public string MIC { get; set; }
		public string InstitutionName { get; set; }
		public string Acronym { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string CountryCode { get; set; }
		public string Website { get; set; }
		public IReadOnlyCollection<StockExchangeAbstract> StockExchanges { get; set; }
	}
}