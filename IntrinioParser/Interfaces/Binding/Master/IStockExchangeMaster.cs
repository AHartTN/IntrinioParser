 namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using Base;

	using Mapping.Many.Detail;
	#endregion

	internal interface IStockExchangeMaster
		: IBaseModel,
		  IStockExchangesable
	{
		string Symbol { get; set; }
		string MIC { get; set; }
		string InstitutionName { get; set; }
		string Acronym { get; set; }
		string City { get; set; }
		string Country { get; set; }
		string CountryCode { get; set; }
		string Website { get; set; }
	}
}