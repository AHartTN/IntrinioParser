using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IValuation : IBaseModel
    {
        int? IntrinioID { get; set; }
        string Status { get; set; }
        decimal? IValue { get; set; }
        decimal? MOSScore { get; set; }
        DateTime? ObservedDate { get; set; }
        int? StartYear { get; set; }
        int? EndYear { get; set; }
        int? FirstHistoricalYear { get; set; }
        int? LastHistoricalYear { get; set; }
        int? FirstProjectedYear { get; set; }
        int? LastProjectedYear { get; set; }
        string LastReportedFiscalQuarter { get; set; }
        DateTime? CreatedOn { get; set; }
        DateTime? UpdatedOn { get; set; }
    }
}
