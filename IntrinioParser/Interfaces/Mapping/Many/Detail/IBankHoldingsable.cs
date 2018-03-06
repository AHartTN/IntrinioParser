using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Mapping.Many.Detail
{
    internal interface IBankHoldingsable
    {
        ICollection<BankHolding> BankHoldings { get; set; }
    }
}
