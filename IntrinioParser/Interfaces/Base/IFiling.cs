namespace IntrinioParser.Interfaces.Base
{
	#region
	using System;
	#endregion

	internal interface IFiling : IBaseModel
	{
		DateTime? FilingDate { get; set; }
		DateTime? AcceptedDate { get; set; }
		DateTime? PeriodEnded { get; set; }
		string AccNo { get; set; }
		string ReportType { get; set; }
		string FilingUrl { get; set; }
		string ReportUrl { get; set; }
		string InstanceUrl { get; set; }
	}
}