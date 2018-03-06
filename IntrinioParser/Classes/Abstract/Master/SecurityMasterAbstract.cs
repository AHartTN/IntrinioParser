namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System;
	using System.Collections.Generic;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class SecurityMasterAbstract
		: BaseAbstract,
		  ISecurityMaster
	{
		internal SecurityMasterAbstract()
		{
			DataType = IntrinioDataType.Securities;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Securities = new HashSet<Security>();
		}

		#region Implementation of ISecuritiesable
		[Hidden]
		public virtual ICollection<Security> Securities { get; set; }
		#endregion

		#region Implementation of ISecurityMaster
		[JsonProperty("ticker")]
		public string Ticker { get; set; }

		[JsonProperty("figi_ticker")]
		public string FIGITicker { get; set; }

		[JsonProperty("figi")]
		public string FIGI { get; set; }

		[JsonProperty("security_name")]
		public string SecurityName { get; set; }

		[JsonProperty("market_sector")]
		public string MarketSector { get; set; }

		[JsonProperty("security_type")]
		public string SecurityType { get; set; }

		[JsonProperty("stock_exchange")]
		public string StockExchange { get; set; }

		[JsonProperty("last_crsp_adj_date")]
		public DateTime? LastCRSPAdjDate { get; set; }
		#endregion
	}
}