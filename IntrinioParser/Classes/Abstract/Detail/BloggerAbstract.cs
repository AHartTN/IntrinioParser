namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class BloggerAbstract
		: BaseAbstract,
		  IBlogger
	{
		internal BloggerAbstract()
		{
			DataType = IntrinioDataType.Bloggers;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IExternal
		[JsonProperty("")]
		public int? IntrinioID { get; set; }

		[JsonProperty("")]
		public string Source { get; set; }

		[JsonProperty("")]
		public string ExternalID { get; set; }
		#endregion
	}
}