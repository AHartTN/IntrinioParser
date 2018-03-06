namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System.Collections.Generic;

	using Attributes;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class OwnerMasterAbstract
		: BaseAbstract,
		  IOwnerMaster
	{
		internal OwnerMasterAbstract()
		{
			DataType = IntrinioDataType.Owners;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Owners = new HashSet<Owner>();
		}

		#region Implementation of IOwnersable
		[Hidden]
		public virtual ICollection<Owner> Owners { get; set; }
		#endregion

		#region Implementation of IOwnerMaster
		[JsonProperty("owner_cik")]
		public string OwnerCIK { get; set; }

		[JsonProperty("owner_name")]
		public string OwnerName { get; set; }
		#endregion
	}
}