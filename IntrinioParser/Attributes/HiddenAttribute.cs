using System;

namespace IntrinioParser.Attributes
{
	public class HiddenAttribute : Attribute
	{
		public HiddenAttribute(bool isHidden = true)
		{
			IsHidden = isHidden;
		}

		public bool IsHidden { get; protected set; }
	}
}