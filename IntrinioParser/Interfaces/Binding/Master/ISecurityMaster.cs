namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using System;

	using Base;

	using Mapping.Many.Detail;
	#endregion

	internal interface ISecurityMaster
		: IBaseModel,
		  ISecuritiesable
	{
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string SecurityName { get; set; }
		string MarketSector { get; set; }
		string SecurityType { get; set; }
		string StockExchange { get; set; }
		DateTime? LastCRSPAdjDate { get; set; }
	}
}