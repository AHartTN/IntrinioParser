using System;
using System.Collections.Generic;
using IntrinioParser.Attributes;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding;
using IntrinioParser.Models.Binding;
using Newtonsoft.Json;

namespace IntrinioParser.Models.Abstract
{
	public abstract class SecurityMasterAbstract : IntrinioAbstract, ISecurityMaster
	{
		protected SecurityMasterAbstract()
		{
			DataType = DataType.Security;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Securities = new HashSet<Security>();
		}

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

		[Hidden]
		public ICollection<Security> Securities { get; set; }
	}
}