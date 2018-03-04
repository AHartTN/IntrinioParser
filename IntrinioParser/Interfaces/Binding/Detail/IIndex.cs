namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Base;

	using Mapping.Single.Master;

	using Microsoft.Extensions.Primitives;
	#endregion

	internal interface IIndex
		: IBaseModel,
		  IIndexMasterable
	{
		string Symbol { get; set; }
		string IndexName { get; set; }
		string IndexType { get; set; }
		string Continent { get; set; }
		string Country { get; set; }
		string FredSymbol { get; set; }
		string Description { get; set; }
		string UpdateFrequency { get; set; }
		string LastUpdated { get; set; }
		string ObservationStart { get; set; }
		string ObservationEnd { get; set; }
		string Popularity { get; set; }
		string SeasonalAdjustment { get; set; }
		string SeasonalAdjustmentShort { get; set; }
		string Units { get; set; }
		string UnitsShort { get; set; }
	}
}