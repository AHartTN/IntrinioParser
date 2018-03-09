namespace IntrinioParser.Interfaces.Binding.Master
{
	#region
	using System;

	using Base;
	#endregion

	internal interface IPressReleaseMaster : IBaseModel
	{
		string Ticker { get; set; }
		string FIGITicker { get; set; }
		string FIGI { get; set; }
		string IssuerName { get; set; }
		string Title { get; set; }
		DateTime? PublicationDate { get; set; }
		string Url { get; set; }
		string Summary { get; set; }
	}
}