namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;
	using System.ComponentModel.DataAnnotations.Schema;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;

	using Newtonsoft.Json;
	#endregion

	internal abstract class SecurityAbstract
		: BaseAbstract,
		  ISecurity
	{
		internal SecurityAbstract()
		{
			DataType = DataType.Security;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ISecurityMasterable
		[ForeignKey("SecurityMaster")]
		public int SecurityMasterID { get; set; }

		[Hidden]
		public virtual SecurityMaster SecurityMaster { get; set; }
		#endregion

		#region Implementation of ISecurity
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

		[JsonProperty("composite_figi")]
		public string CompositeFIGI { get; set; }

		[JsonProperty("composite_figi_ticker")]
		public string CompositeFIGITicker { get; set; }

		[JsonProperty("figi_uniqueid")]
		public string FIGIUniqueID { get; set; }

		[JsonProperty("share_class_figi")]
		public string ShareClassFIGI { get; set; }

		[JsonProperty("figi_exch_cntry")]
		public string FIGIExchCntry { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("mic")]
		public string MIC { get; set; }

		[JsonProperty("exch_symbol")]
		public string ExchSymbol { get; set; }

		[JsonProperty("etf")]
		public bool? ETF { get; set; }

		[JsonProperty("delisted_security")]
		public bool? DelistedSecurity { get; set; }

		[JsonProperty("primary_listing")]
		public bool? PrimaryListing { get; set; }
		#endregion
	}
}