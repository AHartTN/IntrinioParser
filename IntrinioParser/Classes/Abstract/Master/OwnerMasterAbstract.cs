namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;
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
		public ICollection<Owner> Owners { get; set; }
		#endregion

		#region Implementation of IOwnerMaster
		public string OwnerCIK { get; set; }
		public string OwnerName { get; set; }
		#endregion
	}
}