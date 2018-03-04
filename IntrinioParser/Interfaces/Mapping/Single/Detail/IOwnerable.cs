namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	#region
	using Models.Binding.Detail;
	#endregion

	internal interface IOwnerable
	{
		int OwnerID { get; set; }
		Owner Owner { get; set; }
	}
}