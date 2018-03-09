namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System;
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;
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
		public ICollection<Security> Securities { get; set; }
		#endregion

		#region Implementation of ISecurityMaster
		public string Ticker { get; set; }
		public string FIGITicker { get; set; }
		public string FIGI { get; set; }
		public string SecurityName { get; set; }
		public string MarketSector { get; set; }
		public string SecurityType { get; set; }
		public string StockExchange { get; set; }
		public DateTime? LastCRSPAdjDate { get; set; }
		#endregion
	}
}