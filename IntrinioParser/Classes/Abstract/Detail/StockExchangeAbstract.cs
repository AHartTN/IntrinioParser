namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;

	using Newtonsoft.Json;
	#endregion

	internal abstract class StockExchangeAbstract
		: BaseAbstract,
		  IStockExchange
	{
		internal StockExchangeAbstract()
		{
			DataType = IntrinioDataType.StockExchanges;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IStockExchangeMasterable
		[JsonProperty("")]
		public int StockExchangeMasterID { get; set; }

		[JsonProperty("")]
		public StockExchangeMaster StockExchangeMaster { get; set; }
		#endregion
	}
}