namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Base;
	#endregion

	internal interface ILatestSECFiling : IFiling
	{
		string Ticker { get; set; }
		string LEI { get; set; }
		string CIK { get; set; }
	}
}