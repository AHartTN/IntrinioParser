using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    internal interface ISalesSuprise : ISuprise
    {
        DateTime? LastRevDate { get; set; }
        decimal? SalesActual { get; set; }
        decimal? SalesActualZacksAdj { get; set; }
        decimal? SalesActualGAAP { get; set; }
        decimal? SalesMeanEstimate { get; set; }
        decimal? SalesAmountDiff { get; set; }
        decimal? SalesPercentDiff { get; set; }
        decimal? SalesCountEstimate { get; set; }
        decimal? SalesStdDevEstimate { get; set; }
    }
}
