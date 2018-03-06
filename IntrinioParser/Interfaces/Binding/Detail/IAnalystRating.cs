using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;

    using Enumerators;

    internal interface IAnalystRating : IBaseModel
    {
        DateTime? Date { get; set; }
        string Ticker { get; set; }
        string FIGITicker { get; set; }
        string FIGI { get; set; }
        string Sector { get; set; }
        int? AnalystIntrinioID { get; set; }
        int? AnalystFirmIntrinioID { get; set; }
        string AnalystFirmName { get; set; }
        AnalystAction Action { get; set; }
        RecommendationRating Rating { get; set; }
        decimal? PriceTarget { get; set; }
        string Source { get; set; }
    }
}
