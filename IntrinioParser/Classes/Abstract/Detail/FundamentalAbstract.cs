namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Interfaces.Base;

	using Newtonsoft.Json;
	#endregion

	internal abstract class FundamentalAbstract
		: BaseAbstract,
		  IFundamental
	{
		internal FundamentalAbstract()
		{
			//DataType = IntrinioDataType.StandardizedFundamentals;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IFundamental
		[JsonProperty("")]
		public string StatementCopde { get; set; }

		[JsonProperty("")]
		public int? FiscalYear { get; set; }

		[JsonProperty("")]
		public string FiscalPeriod { get; set; }

		[JsonProperty("")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("")]
		public DateTime? StartDate { get; set; }

		[JsonProperty("")]
		public int? Months { get; set; }

		[JsonProperty("")]
		public string Report { get; set; }
		#endregion
	}
}