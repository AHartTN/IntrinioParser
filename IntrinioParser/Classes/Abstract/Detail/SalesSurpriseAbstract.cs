namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class SalesSurpriseAbstract
		: SurpriseAbstract,
		  ISalesSurprise
	{
		internal SalesSurpriseAbstract()
		{
			DataType = IntrinioDataType.SecuritiesEPSSurprises;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ISalesSurprise
		[JsonProperty("")]
		public DateTime? LastRevDate { get; set; }

		[JsonProperty("")]
		public decimal? SalesActual { get; set; }

		[JsonProperty("")]
		public decimal? SalesActualZacksAdj { get; set; }

		[JsonProperty("")]
		public decimal? SalesActualGAAP { get; set; }

		[JsonProperty("")]
		public decimal? SalesMeanEstimate { get; set; }

		[JsonProperty("")]
		public decimal? SalesAmountDiff { get; set; }

		[JsonProperty("")]
		public decimal? SalesPercentDiff { get; set; }

		[JsonProperty("")]
		public decimal? SalesCountEstimate { get; set; }

		[JsonProperty("")]
		public decimal? SalesStdDevEstimate { get; set; }
		#endregion
	}
}