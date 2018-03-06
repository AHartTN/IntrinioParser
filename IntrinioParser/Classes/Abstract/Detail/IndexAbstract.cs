namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System.ComponentModel.DataAnnotations.Schema;

	using Attributes;

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
		[ForeignKey("IndexMaster")]
		public int IndexMasterID { get; set; }

		[Hidden]
		public virtual IndexMaster IndexMaster { get; set; }
		#endregion

		#region Implementation of IIndex
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("index_name")]
		public string IndexName { get; set; }

		[JsonProperty("index_type")]
		public string IndexType { get; set; }

		[JsonProperty("continent")]
		public string Continent { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("fred_symbol")]
		public string FredSymbol { get; set; }

		[JsonProperty("update_frequency")]
		public string UpdateFrequency { get; set; }

		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }

		[JsonProperty("observation_start")]
		public string ObservationStart { get; set; }

		[JsonProperty("observation_end")]
		public string ObservationEnd { get; set; }

		[JsonProperty("popularity")]
		public string Popularity { get; set; }

		[JsonProperty("seasonal_adjustment")]
		public string SeasonalAdjustment { get; set; }

		[JsonProperty("seasonal_adjustment_short")]
		public string SeasonalAdjustmentShort { get; set; }

		[JsonProperty("units")]
		public string Units { get; set; }

		[JsonProperty("units_short")]
		public string UnitsShort { get; set; }
		#endregion
	}
}