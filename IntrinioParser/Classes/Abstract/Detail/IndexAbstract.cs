namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;

	using Newtonsoft.Json;
	#endregion

	internal abstract class IndexAbstract
		: BaseAbstract,
		  IIndex
	{
		internal IndexAbstract()
		{
			DataType = IntrinioDataType.Indices;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IIndexMasterable
		public int IndexMasterID { get; set; }
		public IndexMaster IndexMaster { get; set; }
		#endregion

		#region Implementation of IIndex
		[JsonProperty("")]
		public string Symbol { get; set; }

		[JsonProperty("")]
		public string IndexName { get; set; }

		[JsonProperty("")]
		public string IndexType { get; set; }

		[JsonProperty("")]
		public string Continent { get; set; }

		[JsonProperty("")]
		public string Country { get; set; }

		[JsonProperty("")]
		public string FredSymbol { get; set; }

		[JsonProperty("")]
		public string Description { get; set; }

		[JsonProperty("")]
		public string UpdateFrequency { get; set; }

		[JsonProperty("")]
		public string LastUpdated { get; set; }

		[JsonProperty("")]
		public string ObservationStart { get; set; }

		[JsonProperty("")]
		public string ObservationEnd { get; set; }

		[JsonProperty("")]
		public string Popularity { get; set; }

		[JsonProperty("")]
		public string SeasonalAdjustment { get; set; }

		[JsonProperty("")]
		public string SeasonalAdjustmentShort { get; set; }

		[JsonProperty("")]
		public string Units { get; set; }

		[JsonProperty("")]
		public string UnitsShort { get; set; }
		#endregion
	}
}