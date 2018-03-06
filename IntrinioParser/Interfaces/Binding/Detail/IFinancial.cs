using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IFinancial : IBaseModel
    {
        string Tag { get; set; }
        string XBRLTag { get; set; }
        string DomainTag { get; set; }
        object Value { get; set; }
    }
}
