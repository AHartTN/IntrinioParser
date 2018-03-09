namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;

	using Base;
	#endregion

	internal interface INews : IBaseModel
	{
		string Title { get; set; }
		DateTime? PublicationDate { get; set; }
		string Url { get; set; }
		string Summary { get; set; }
	}
}