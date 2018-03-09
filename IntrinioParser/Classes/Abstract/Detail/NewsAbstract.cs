namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class NewsAbstract
		: BaseAbstract,
		  INews
	{
		internal NewsAbstract()
		{
			DataType = IntrinioDataType.CompanyNews;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of INews
		[JsonProperty("")]
		public string Title { get; set; }

		[JsonProperty("")]
		public DateTime? PublicationDate { get; set; }

		[JsonProperty("")]
		public string Url { get; set; }

		[JsonProperty("")]
		public string Summary { get; set; }
		#endregion
	}
}