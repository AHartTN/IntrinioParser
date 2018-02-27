using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;
using IntrinioParser.Models.Binding;

namespace IntrinioParser.Models.Mapping.CSV
{
    public sealed class IndexMasterCSVMap : ClassMap<IndexMaster>
    {
	    public IndexMasterCSVMap()
	    {
			Map(m => m.Symbol).Name("SYMBOL").NameIndex(0).Default(null);
		    Map(m => m.IndexName).Name("INDEX_NAME").NameIndex(0).Default(null);
		}
	}
}
