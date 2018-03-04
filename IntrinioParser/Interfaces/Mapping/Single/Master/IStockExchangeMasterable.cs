namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	#region
	using Models.Binding.Master;
	#endregion

	internal interface IStockExchangeMasterable
	{
		int StockExchangeMasterID { get; set; }
		StockExchangeMaster StockExchangeMaster { get; set; }
	}
}