using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IBankDeposit : IBaseModel
    {
        int BankBranchID { get; set; }
        DateTime? ReportedDate { get; set; }
        int? Year { get; set; }
        decimal? TotalDeposits { get; set; }
        BankBranch BankBranch { get; set; }
    }
}
