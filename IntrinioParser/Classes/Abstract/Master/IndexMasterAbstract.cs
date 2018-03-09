namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;
	#endregion

	internal abstract class IndexMasterAbstract
		: BaseAbstract,
		  IIndexMaster
	{
		internal IndexMasterAbstract()
		{
			DataType = IntrinioDataType.Indices;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Indices = new HashSet<Index>();
		}

		#region Implementation of IIndicesable
		public ICollection<Index> Indices { get; set; }
		#endregion

		#region Implementation of IIndexMaster
		public string Symbol { get; set; }
		public string IndexName { get; set; }
		public string Country { get; set; }
		public string Continent { get; set; }
		public string IndexType { get; set; }
		#endregion
	}
}