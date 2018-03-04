namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	#region
	using Models.Binding.Master;
	#endregion

	internal interface IIndexMasterable
	{
		int IndexMasterID { get; set; }
		IndexMaster IndexMaster { get; set; }
	}
}