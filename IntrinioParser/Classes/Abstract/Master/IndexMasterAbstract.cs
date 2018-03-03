using System.Collections.Generic;
using IntrinioParser.Attributes;
using IntrinioParser.Classes.Abstract.Base;
using IntrinioParser.Classes.Abstract.Detail;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding.Master;
using Newtonsoft.Json;

namespace IntrinioParser.Classes.Abstract.Master
{
	public abstract class IndexMasterAbstract : IntrinioAbstract, IIndexMaster
	{
		public IndexMasterAbstract()
		{
			DataType = DataType.Index;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Indices = new HashSet<IndexAbstract>();
		}

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("index_name")]
		public string IndexName { get; set; }

		[Hidden]
		public ICollection<IndexAbstract> Indices { get; set; }
	}
}