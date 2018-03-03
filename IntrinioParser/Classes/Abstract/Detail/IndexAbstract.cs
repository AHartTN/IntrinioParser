using IntrinioParser.Attributes;
using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Master;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Detail;
using Newtonsoft.Json;

namespace IntrinioParser.Classes.Abstract.Detail
{
	public abstract class IndexAbstract : IntrinioAbstract, IIndex
	{
		public IndexAbstract()
		{
			DataType = DataType.Index;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		public int IndexMasterID { get; set; }

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

		[Hidden]
		public IndexMasterAbstract IndexMaster { get; set; }
	}
}