using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;

    internal interface IBankHolding : IBaseModel
    {
        int RSSDID { get; set; }
        string Name { get; set; }
        string City { get; set; }
        string State { get; set; }
        ICollection<Bank> Banks { get; set; }
    }
}
