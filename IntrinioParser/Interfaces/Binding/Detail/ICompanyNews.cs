using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface ICompanyNews : IBaseModel
    {
        string Title { get; set; }
        DateTime? PublicationDate { get; set; }
        string Url { get; set; }
        string Summary { get; set; }
    }
}
