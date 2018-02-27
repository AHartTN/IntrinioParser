using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Binding;
using Newtonsoft.Json;

namespace IntrinioParser.Models.Abstract
{
    public abstract class IndexMasterAbstract : IntrinioAbstract, IIndexMaster
    {
	    protected IndexMasterAbstract()
	    {
			DataType = DataType.Index;
			//FileType = FileType.CSV;
		    SchemaName = DataType.ToString();
		    TableName = "Master";
			//Indices = new HashSet<Index>();
		}

		[JsonProperty("symbol")]
		public string Symbol { get; set; }
	    [JsonProperty("index_name")]
	    public string IndexName { get; set; }
    }
}
