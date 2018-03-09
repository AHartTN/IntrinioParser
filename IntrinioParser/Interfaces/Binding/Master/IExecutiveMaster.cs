namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using Base;
	#endregion

	internal interface IExecutiveMaster : IBaseModel
	{
		string Identifier { get; set; }
		string FullName { get; set; }
		string Type { get; set; }
	}
}