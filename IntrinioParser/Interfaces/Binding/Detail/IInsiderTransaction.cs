using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IInsiderTransaction : IBaseModel
    {
        string Identifier { get; set; }
        string Ticker { get; set; }
        string CompanyCIK { get; set; }
        string CompanyName { get; set; }
        string OwnerCIK { get; set; }
        string OwnerName { get; set; }
        DateTime? FilingDate { get; set; }
        string FilingUrl { get; set; }
        bool? Director { get; set; }
        bool? Officer { get; set; }
        bool? TenPercentOwner { get; set; }
        bool? OtherRelation { get; set; }
        string OfficerTitle { get; set; }
        bool? DerivativeTransaction { get; set; }
        string SecurityTitle { get; set; }
        DateTime? TransactionDate { get; set; }
        DateTime? DeemedExecutionDate { get; set; }
        string TransactionTypeCode { get; set; }
        decimal? AmountOfShares { get; set; }
        string AcquisitionDispositionCode { get; set; }
        decimal? TransactionPrice { get; set; }
        decimal? TotalSharesOwned { get; set; }
        string OwnershipTypeCode { get; set; }
        string NatureOfOwnership { get; set; }
        int? ReportLineNumber { get; set; }
        decimal? ConversionExercisePrice { get; set; }
        DateTime? ExerciseDate { get; set; }
        string UnderlyingSecurityTitle { get; set; }
        decimal? UnderlyingShares { get; set; }

    }
}
