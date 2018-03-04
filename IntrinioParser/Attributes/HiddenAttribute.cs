namespace IntrinioParser.Attributes
{
	#region
	using System;
	#endregion

	internal sealed class HiddenAttribute : Attribute
	{
		public bool IsHidden { get; }

		public HiddenAttribute(bool isHidden = true)
		{
			IsHidden = isHidden;
		}
	}
}