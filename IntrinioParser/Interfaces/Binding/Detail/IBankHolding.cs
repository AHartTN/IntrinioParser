namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System.Collections.Generic;

	using Base;

	using Models.Binding.Detail;
	#endregion

	internal interface IBankHolding : IBaseModel
	{
		int RSSDID { get; set; }
		string Name { get; set; }
		string City { get; set; }
		string State { get; set; }
		ICollection<Bank> Banks { get; set; }
	}
}