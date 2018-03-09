namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

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
			DataType = IntrinioDataType.Securities;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ISecurityMasterable
		[JsonProperty("")]
		public int SecurityMasterID { get; set; }

		[JsonProperty("")]
		public SecurityMaster SecurityMaster { get; set; }
		#endregion

		#region Implementation of ISecurity
		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public string SecurityName { get; set; }

		[JsonProperty("")]
		public string MarketSector { get; set; }

		[JsonProperty("")]
		public string SecurityType { get; set; }

		[JsonProperty("")]
		public string StockExchange { get; set; }

		[JsonProperty("")]
		public DateTime? LastCRSPAdjDate { get; set; }

		[JsonProperty("")]
		public string CompositeFIGI { get; set; }

		[JsonProperty("")]
		public string CompositeFIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGIUniqueID { get; set; }

		[JsonProperty("")]
		public string ShareClassFIGI { get; set; }

		[JsonProperty("")]
		public string FIGIExchCntry { get; set; }

		[JsonProperty("")]
		public string Currency { get; set; }

		[JsonProperty("")]
		public string MIC { get; set; }

		[JsonProperty("")]
		public string ExchSymbol { get; set; }

		[JsonProperty("")]
		public bool? ETF { get; set; }

		[JsonProperty("")]
		public bool? DelistedSecurity { get; set; }

		[JsonProperty("")]
		public bool? PrimaryListing { get; set; }
		#endregion
	}
}