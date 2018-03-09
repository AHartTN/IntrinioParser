namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Interfaces.Base;

	using Newtonsoft.Json;
	#endregion

	internal abstract class FinancialAbstract
		: BaseAbstract,
		  IFinancial
	{
		internal FinancialAbstract()
		{
			//DataType = IntrinioDataType.AsReportedFinancials;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IFinancial
		[JsonProperty("")]
		public string Tag { get; set; }

		[JsonProperty("")]
		public string XBRLTag { get; set; }

		[JsonProperty("")]
		public string DomainTag { get; set; }

		[JsonProperty("")]
		public object Value { get; set; }
		#endregion
	}
}