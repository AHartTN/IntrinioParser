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
		[Hidden]
		public virtual ICollection<Index> Indices { get; set; }
		#endregion

		#region Implementation of IIndexMaster
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("index_name")]
		public string IndexName { get; set; }
		#endregion
	}
}