using System;

namespace IntrinioParser.Attributes
{
	internal sealed class HiddenAttribute : Attribute
	{
		public HiddenAttribute(bool isHidden = true)
		{
			IsHidden = isHidden;
		}

		public bool IsHidden { get; }
	}
}