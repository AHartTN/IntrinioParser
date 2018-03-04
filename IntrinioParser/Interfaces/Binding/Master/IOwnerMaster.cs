namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using Base;

	using Mapping.Many.Detail;
	#endregion

	internal interface IOwnerMaster
		: IBaseModel,
		  IOwnersable
	{
		string OwnerCIK { get; set; }
		string OwnerName { get; set; }
	}
}