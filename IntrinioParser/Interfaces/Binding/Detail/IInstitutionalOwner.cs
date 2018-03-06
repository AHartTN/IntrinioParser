using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IInstitutionalOwner : IBaseModel
    {
        string OwnerCIK { get; set; }
        string OwnerName { get; set; }
        DateTime? PeriodEnded { get; set; }
        decimal? Value { get; set; }
        decimal? Amount { get; set; }
        decimal? SoleVotingAuthority { get; set; }
        decimal? SharedVotingAuthority { get; set; }
        decimal? NoVotingAuthority { get; set; }
        decimal? PrevAmount { get; set; }
        decimal? AmountChg { get; set; }
        decimal? AmountPctChg { get; set; }
    }
}
