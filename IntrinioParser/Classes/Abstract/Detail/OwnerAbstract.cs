namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System.ComponentModel.DataAnnotations.Schema;

	using Attributes;

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
		[ForeignKey("OwnerMaster")]
		public int OwnerMasterID { get; set; }

		[Hidden]
		public virtual OwnerMaster OwnerMaster { get; set; }
		#endregion

		#region Implementation of IOwner
		[JsonProperty("owner_cik")]
		public string OwnerCIK { get; set; }

		[JsonProperty("owner_name")]
		public string OwnerName { get; set; }
		#endregion
	}
}