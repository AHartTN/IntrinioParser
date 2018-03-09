namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Master;
	#endregion

	internal interface IPressReleaseContent : IPressReleaseMaster
	{
		string IssuerCity { get; set; }
		string IssuerState { get; set; }
		string IssuerPostalCode { get; set; }
		string IssuerCountry { get; set; }
		string IssuerIndustry { get; set; }
		string ArticleRevision { get; set; }
		string ArticleLanguage { get; set; }
		string Keywords { get; set; }
		string Content { get; set; }
		string Distributor { get; set; }
		string Body { get; set; }
	}
}