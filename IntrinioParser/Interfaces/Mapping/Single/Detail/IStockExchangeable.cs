namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	#region
	using Models.Binding.Detail;
	#endregion

	internal interface IStockExchangeable
	{
		int StockExchangeID { get; set; }
		StockExchange StockExchange { get; set; }
	}
}