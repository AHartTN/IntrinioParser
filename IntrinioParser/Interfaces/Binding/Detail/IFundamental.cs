using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
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
