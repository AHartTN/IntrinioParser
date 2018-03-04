namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System.Collections.Generic;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class StockExchangeMasterAbstract
		: BaseAbstract,
		  IStockExchangeMaster
	{
		internal StockExchangeMasterAbstract()
		{
			DataType = DataType.StockExchange;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			StockExchanges = new HashSet<StockExchange>();
		}

		#region Implementation of IStockExchangesable
		[Hidden]
		public virtual ICollection<StockExchange> StockExchanges { get; set; }
		#endregion

		#region Implementation of IStockExchangeMaster
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("mic")]
		public string MIC { get; set; }

		[JsonProperty("institution_name")]
		public string InstitutionName { get; set; }

		[JsonProperty("acronym")]
		public string Acronym { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("website")]
		public string Website { get; set; }
		#endregion
	}
}