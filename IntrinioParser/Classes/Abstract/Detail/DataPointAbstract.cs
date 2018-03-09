namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class DataPointAbstract
		: BaseAbstract,
		  IDataPoint
	{
		internal DataPointAbstract()
		{
			DataType = IntrinioDataType.DataPoint;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IDataPoint
		[JsonProperty("")]
		public string Identifier { get; set; }

		[JsonProperty("")]
		public string Item { get; set; }

		[JsonProperty("")]
		public object Value { get; set; }
		#endregion
	}
}