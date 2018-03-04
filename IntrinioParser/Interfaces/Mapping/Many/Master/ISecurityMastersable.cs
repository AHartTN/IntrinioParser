namespace IntrinioParser.Interfaces.Mapping.Many.Master
{
	#region
	using System.Collections.Generic;

	using Models.Binding.Master;
	#endregion

	internal interface ISecurityMastersable
	{
		ICollection<SecurityMaster> SecurityMasters { get; set; }
	}
}