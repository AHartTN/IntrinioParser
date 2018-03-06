using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
    using Base;
    internal interface IOptionExpiration : IBaseModel
    {
        ICollection<DateTime> Data { get; set; }
    }
}
