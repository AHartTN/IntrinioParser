using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface ICompanySECFiling : IBaseModel
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
