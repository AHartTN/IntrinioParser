namespace IntrinioParser.Interfaces.Mapping.Many.Master
{
	#region
	using System.Collections.Generic;

	using Models.Binding.Master;
	#endregion

	internal interface IOwnerMastersable
	{
		ICollection<OwnerMaster> OwnerMasters { get; set; }
	}
}