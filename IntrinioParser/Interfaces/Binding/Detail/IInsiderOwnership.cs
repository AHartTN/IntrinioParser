using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IInsiderOwnership : IBaseModel
    {
        string Identifier { get; set; }
        string CompanyCIK { get; set; }
        string CompanyName { get; set; }
        string OwnerCIK { get; set; }
        string OwnerName { get; set; }
        DateTime? LastReportedDate { get; set; }
        decimal? Value { get; set; }
        decimal? Amount { get; set; }
    }
}
