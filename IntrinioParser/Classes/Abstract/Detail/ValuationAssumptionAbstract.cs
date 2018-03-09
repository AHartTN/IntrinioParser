namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class ValuationAssumptionAbstract
		: BaseAbstract,
		  IValuationAssumption
	{
		internal ValuationAssumptionAbstract()
		{
			//DataType = IntrinioDataType;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IValuationAssumption
		[JsonProperty("")]
		public string DataTag { get; set; }

		[JsonProperty("")]
		public int? FiscalYear { get; set; }

		[JsonProperty("")]
		public object Value { get; set; }
		#endregion
	}
}