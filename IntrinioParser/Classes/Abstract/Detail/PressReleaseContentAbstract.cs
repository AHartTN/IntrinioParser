namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class PressReleaseContentAbstract
		: BaseAbstract,
		  IPressReleaseContent
	{
		internal PressReleaseContentAbstract()
		{
			DataType = IntrinioDataType.PressReleaseContent;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IPressReleaseMaster
		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public string IssuerName { get; set; }

		[JsonProperty("")]
		public string Title { get; set; }

		[JsonProperty("")]
		public DateTime? PublicationDate { get; set; }

		[JsonProperty("")]
		public string Url { get; set; }

		[JsonProperty("")]
		public string Summary { get; set; }
		#endregion

		#region Implementation of IPressReleaseContent
		[JsonProperty("")]
		public string IssuerCity { get; set; }

		[JsonProperty("")]
		public string IssuerState { get; set; }

		[JsonProperty("")]
		public string IssuerPostalCode { get; set; }

		[JsonProperty("")]
		public string IssuerCountry { get; set; }

		[JsonProperty("")]
		public string IssuerIndustry { get; set; }

		[JsonProperty("")]
		public string ArticleRevision { get; set; }

		[JsonProperty("")]
		public string ArticleLanguage { get; set; }

		[JsonProperty("")]
		public string Keywords { get; set; }

		[JsonProperty("")]
		public string Content { get; set; }

		[JsonProperty("")]
		public string Distributor { get; set; }

		[JsonProperty("")]
		public string Body { get; set; }
		#endregion
	}
}