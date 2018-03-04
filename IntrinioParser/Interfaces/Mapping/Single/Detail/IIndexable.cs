namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	#region
	using Models.Binding.Detail;
	#endregion

	internal interface IIndexable
	{
		int IndexID { get; set; }
		Index Index { get; set; }
	}
}