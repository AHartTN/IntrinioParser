using System.Collections.Generic;
using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Detail;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Master;
using Newtonsoft.Json;

namespace IntrinioParser.Classes.Abstract.Master
{
	public abstract class OwnerMasterAbstract : IntrinioAbstract, IOwnerMaster
	{
		public OwnerMasterAbstract()
		{
			DataType = DataType.Owner;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Owners = new HashSet<OwnerAbstract>();
		}

		[JsonProperty("owner_cik")]
		public string OwnerCIK { get; set; }

		[JsonProperty("owner_name")]
		public string OwnerName { get; set; }

		public ICollection<OwnerAbstract> Owners { get; set; }
	}
}