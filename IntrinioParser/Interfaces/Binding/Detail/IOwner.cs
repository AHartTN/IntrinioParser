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
		string BusinessAddress { get; set; }
		string MailingAddress { get; set; }
		string State { get; set; }
		string StateInc { get; set; }
		string CountryInc { get; set; }
		string BusinessPhoneNumber { get; set; }
		bool? Institutional { get; set; }
	}
}