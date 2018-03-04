namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	#region
	using Models.Binding.Detail;
	#endregion

	internal interface ISecurityable
	{
		int SecurityID { get; set; }
		Security Security { get; set; }
	}
}