namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System.ComponentModel.DataAnnotations.Schema;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;
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

		//
		//public int StockExchangeMasterID { get; set; }
		//public StockExchangeMaster StockExchangeMaster { get; set; }

		#region Implementation of IStockExchangeMasterable
		[ForeignKey("StockExchangeMaster")]
		public int StockExchangeMasterID { get; set; }

		[Hidden]
		public virtual StockExchangeMaster StockExchangeMaster { get; set; }
		#endregion
	}
}