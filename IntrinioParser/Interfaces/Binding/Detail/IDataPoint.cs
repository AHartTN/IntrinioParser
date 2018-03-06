using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IDataPoint : IBaseModel
    {
        string Identifier { get; set; }
        string Item { get; set; }
        object Value { get; set; }
    }
}
