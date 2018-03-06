using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IExternal : IBaseModel
    {
        int? IntrinioID { get; set; }
        string Source { get; set; }
        string ExternalID { get; set; }
    }
}
