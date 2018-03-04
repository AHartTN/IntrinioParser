namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	#region
	using Models.Binding.Master;
	#endregion

	internal interface ISecurityMasterable
	{
		int SecurityMasterID { get; set; }
		SecurityMaster SecurityMaster { get; set; }
	}
}