namespace IntrinioParser.Interfaces.Base
{
	#region
	using System;
	#endregion

	internal interface IFundamental : IBaseModel
	{
		string StatementCopde { get; set; }
		int? FiscalYear { get; set; }
		string FiscalPeriod { get; set; }
		DateTime? EndDate { get; set; }
		DateTime? StartDate { get; set; }
		int? Months { get; set; }
		string Report { get; set; }
	}
}