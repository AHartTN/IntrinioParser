using System;
using System.Collections.Generic;
using System.Text;

namespace IntrinioParser.Interfaces.Binding.Detail
{
	using Base;

	internal interface ITag : IBaseModel
	{
		string Name { get; set; }
		string Tag { get; set; }
		string Parent { get; set; }
		string Factor { get; set; }
		string Balance { get; set; }
		string DomainTag { get; set; }
		bool? Abstract { get; set; }
		string Type { get; set; }
		string Unit { get; set; }
		string Units { get; set; }
		int? Sequence { get; set; }
		int? Depth { get; set; }
	}
}
