namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IExecutiveRole : IBaseModel
	{
		string RoleName { get; set; }
		string Company { get; set; }
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string Status { get; set; }
		DateTime? EffectiveDate { get; set; }
		string Division { get; set; }
		bool? ExecutiveDirector { get; set; }
		bool? IndependentDirector { get; set; }
	}
}