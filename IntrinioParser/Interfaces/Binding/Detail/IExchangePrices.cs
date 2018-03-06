using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;

    internal interface IExchangePrices : IPrices
    {
        string Ticker { get; set; }
        string FIGITicker { get; set; }
        string FIGI { get; set; }
    }
}
