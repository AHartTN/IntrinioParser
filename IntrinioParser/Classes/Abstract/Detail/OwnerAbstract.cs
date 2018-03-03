using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Master;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Detail;

namespace IntrinioParser.Classes.Abstract.Detail
{
	public abstract class OwnerAbstract : IntrinioAbstract, IOwner
	{
		public OwnerAbstract()
		{
			DataType = DataType.Owner;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		public int OwnerMasterID { get; set; }
		public OwnerMasterAbstract OwnerMaster { get; set; }
	}
}