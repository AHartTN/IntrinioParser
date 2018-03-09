namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class HistoricalDataAbstract
		: BaseAbstract,
		  IHistoricalData
	{
		internal HistoricalDataAbstract()
		{
			DataType = IntrinioDataType.HistoricalData;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IHistoricalData
		[JsonProperty("")]
		public string Identifier { get; set; }

		[JsonProperty("")]
		public string Item { get; set; }

		[JsonProperty("")]
		public DateTime? Date { get; set; }

		[JsonProperty("")]
		public object Value { get; set; }
		#endregion
	}
}