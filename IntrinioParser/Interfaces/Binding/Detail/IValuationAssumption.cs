namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Base;
	#endregion

	internal interface IValuationAssumption : IBaseModel
	{
		string DataTag { get; set; }
		int? FiscalYear { get; set; }
		object Value { get; set; }
	}
}