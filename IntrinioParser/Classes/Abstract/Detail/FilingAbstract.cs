namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Interfaces.Base;

	using Newtonsoft.Json;
	#endregion

	internal abstract class FilingAbstract
		: BaseAbstract,
		  IFiling
	{
		internal FilingAbstract()
		{
			//DataType = IntrinioDataType.LatestSECFilings;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IFiling
		[JsonProperty("")]
		public DateTime? FilingDate { get; set; }

		[JsonProperty("")]
		public DateTime? AcceptedDate { get; set; }

		[JsonProperty("")]
		public DateTime? PeriodEnded { get; set; }

		[JsonProperty("")]
		public string AccNo { get; set; }

		[JsonProperty("")]
		public string ReportType { get; set; }

		[JsonProperty("")]
		public string FilingUrl { get; set; }

		[JsonProperty("")]
		public string ReportUrl { get; set; }

		[JsonProperty("")]
		public string InstanceUrl { get; set; }
		#endregion
	}
}