namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using Base;

	using Mapping.Many.Detail;
	#endregion

	internal interface IIndexMaster
		: IBaseModel,
		  IIndicesable
	{
		string Symbol { get; set; }
		string IndexName { get; set; }
		string Country { get; set; }
		string Continent { get; set; }
		string IndexType { get; set; }
	}
}