namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Base;

	using Mapping.Single.Master;
	#endregion

	internal interface IOwner
		: IBaseModel,
		  IOwnerMasterable
	{
		string OwnerCIK { get; set; }
		string OwnerName { get; set; }
	}
}