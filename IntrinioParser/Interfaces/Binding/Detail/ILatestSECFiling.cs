using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface ILatestSECFiling : ICompanySECFiling
    {
        string Ticker { get; set; }
        string LEI { get; set; }
        string CIK { get; set; }
    }
}
