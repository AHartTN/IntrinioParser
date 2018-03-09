namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;
	using System.Collections.Generic;

	using Base;
	#endregion

	internal interface IOptionExpiration : IBaseModel
	{
		ICollection<DateTime> Data { get; set; }
	}
}