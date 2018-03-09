namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class EPSSurpriseAbstract
		: SurpriseAbstract,
		  IEPSSurprise
	{
		internal EPSSurpriseAbstract()
		{
			DataType = IntrinioDataType.SecuritiesEPSSurprises;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IEPSSurprise
		[JsonProperty("")]
		public decimal? EPSActual { get; set; }

		[JsonProperty("")]
		public decimal? EPSActualZacksAdj { get; set; }

		[JsonProperty("")]
		public decimal? EPSMeanEstimate { get; set; }

		[JsonProperty("")]
		public decimal? EPSAmountDiff { get; set; }

		[JsonProperty("")]
		public decimal? EPSPercentDiff { get; set; }

		[JsonProperty("")]
		public decimal? EPSCountEstimate { get; set; }

		[JsonProperty("")]
		public decimal? EPSStdDevEstimate { get; set; }
		#endregion
	}
}