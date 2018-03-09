namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;
	#endregion

	internal abstract class StockExchangeMasterAbstract
		: BaseAbstract,
		  IStockExchangeMaster
	{
		internal StockExchangeMasterAbstract()
		{
			DataType = IntrinioDataType.StockExchanges;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			StockExchanges = new HashSet<StockExchange>();
		}

		#region Implementation of IStockExchangesable
		public ICollection<StockExchange> StockExchanges { get; set; }
		#endregion

		#region Implementation of IStockExchangeMaster
		public string Symbol { get; set; }
		public string MIC { get; set; }
		public string InstitutionName { get; set; }
		public string Acronym { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string CountryCode { get; set; }
		public string Website { get; set; }
		#endregion
	}
}