namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Master;

	using Newtonsoft.Json;
	#endregion

	internal abstract class OwnerAbstract
		: BaseAbstract,
		  IOwner
	{
		internal OwnerAbstract()
		{
			DataType = IntrinioDataType.Owners;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IOwnerMasterable
		[JsonProperty("")]
		public int OwnerMasterID { get; set; }

		[JsonProperty("")]
		public OwnerMaster OwnerMaster { get; set; }
		#endregion

		#region Implementation of IOwner
		[JsonProperty("")]
		public string OwnerCIK { get; set; }

		[JsonProperty("")]
		public string OwnerName { get; set; }

		[JsonProperty("")]
		public string BusinessAddress { get; set; }

		[JsonProperty("")]
		public string MailingAddress { get; set; }

		[JsonProperty("")]
		public string State { get; set; }

		[JsonProperty("")]
		public string StateInc { get; set; }

		[JsonProperty("")]
		public string CountryInc { get; set; }

		[JsonProperty("")]
		public string BusinessPhoneNumber { get; set; }

		[JsonProperty("")]
		public bool? Institutional { get; set; }
		#endregion
	}
}