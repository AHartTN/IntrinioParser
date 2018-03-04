namespace IntrinioParser.Interfaces.Mapping.Many.Detail
{
	#region
	using System.Collections.Generic;

	using Models.Binding.Detail;
	#endregion

	internal interface ISecuritiesable
	{
		ICollection<Security> Securities { get; set; }
	}
}