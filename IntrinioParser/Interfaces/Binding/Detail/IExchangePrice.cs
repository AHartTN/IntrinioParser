namespace IntrinioParser.Interfaces.Binding.Detail
{
	internal interface IExchangePrice : IPrices
	{
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
	}
}