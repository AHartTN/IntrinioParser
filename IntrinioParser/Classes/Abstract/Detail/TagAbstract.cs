namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class TagAbstract
		: BaseAbstract,
		  ITag
	{
		internal TagAbstract()
		{
			//DataType = IntrinioDataType;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of ITag
		[JsonProperty("")]
		public string Name { get; set; }

		[JsonProperty("")]
		public string Tag { get; set; }

		[JsonProperty("")]
		public string Parent { get; set; }

		[JsonProperty("")]
		public string Factor { get; set; }

		[JsonProperty("")]
		public string Balance { get; set; }

		[JsonProperty("")]
		public string DomainTag { get; set; }

		[JsonProperty("")]
		public bool? Abstract { get; set; }

		[JsonProperty("")]
		public string Type { get; set; }

		[JsonProperty("")]
		public string Unit { get; set; }

		[JsonProperty("")]
		public string Units { get; set; }

		[JsonProperty("")]
		public int? Sequence { get; set; }

		[JsonProperty("")]
		public int? Depth { get; set; }
		#endregion
	}
}