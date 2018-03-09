namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Base;
	#endregion

	internal interface IDataPoint : IBaseModel
	{
		string Identifier { get; set; }
		string Item { get; set; }
		object Value { get; set; }
	}
}