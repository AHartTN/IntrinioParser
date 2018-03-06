using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IValuationAssumption : IBaseModel
    {
        string DataTag { get; set; }
        int? FiscalYear { get; set; }
        object Value { get; set; }
    }
}
