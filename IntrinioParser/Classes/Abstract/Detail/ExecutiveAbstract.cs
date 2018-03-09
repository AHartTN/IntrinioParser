namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class ExecutiveAbstract
		: BaseAbstract,
		  IExecutive
	{
		internal ExecutiveAbstract()
		{
			DataType = IntrinioDataType.ExecutiveDetails;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IExecutiveMaster
		[JsonProperty("")]
		public string Identifier { get; set; }

		[JsonProperty("")]
		public string FullName { get; set; }

		[JsonProperty("")]
		public string Type { get; set; }
		#endregion

		#region Implementation of IExecutive
		[JsonProperty("")]
		public string Prefix { get; set; }

		[JsonProperty("")]
		public string FirstName { get; set; }

		[JsonProperty("")]
		public string MiddleName { get; set; }

		[JsonProperty("")]
		public string LastName { get; set; }

		[JsonProperty("")]
		public string NickName { get; set; }

		[JsonProperty("")]
		public string Suffix { get; set; }

		[JsonProperty("")]
		public string Gender { get; set; }

		[JsonProperty("")]
		public int? Age { get; set; }

		[JsonProperty("")]
		public int? AgeAsOnDate { get; set; }

		[JsonProperty("")]
		public string ContactStatus { get; set; }
		#endregion
	}
}