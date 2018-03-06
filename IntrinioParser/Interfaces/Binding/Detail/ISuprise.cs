namespace IntrinioParser.Interfaces.Binding.Detail {
	using System;

	using Base;

	internal interface ISuprise : IBaseModel
	{
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		int? FiscalYear { get; set; }
		string FiscalQuarter { get; set; }
		int? CalendarYear { get; set; }
		string CalendarQuarter { get; set; }
		DateTime? ActualReportedDate { get; set; }
		string ActualReportedTime { get; set; }
		string ActualReportedCode { get; set; }
		string ActualReportedDesc { get; set; }
	}
}