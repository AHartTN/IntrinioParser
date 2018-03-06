using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    public interface IHistoricalData
    {
        string Identifier { get; set; }
        string Item { get; set; }
        DateTime? Date { get; set; }
        object Value { get; set; }
    }
}
