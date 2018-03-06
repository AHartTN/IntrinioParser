using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;

    using Enumerators;

    internal interface IBuyerRating : IBaseModel
    {
        DateTime? Date { get; set; }
        string Ticker { get; set; }
        string FIGITicker { get; set; }
        string FIGI { get; set; }
        string Sector { get; set; }
        int? BlogID { get; set; }
        int? BloggerID { get; set; }
        RecommendationRating Rating { get; set; }
        string Source { get; set; }
}
}
