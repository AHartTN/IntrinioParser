namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	#region
	using Models.Binding.Master;
	#endregion

	internal interface IOwnerMasterable
	{
		int OwnerMasterID { get; set; }
		OwnerMaster OwnerMaster { get; set; }
	}
}