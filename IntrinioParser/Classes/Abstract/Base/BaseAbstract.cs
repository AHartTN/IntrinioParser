using System.ComponentModel.DataAnnotations.Schema;
using IntrinioParser.Attributes;
using IntrinioParser.Interfaces.Base;

namespace IntrinioParser.Classes.Abstract.Base
{
	public abstract class BaseAbstract : IBaseModel
	{
		[NotMapped]
		public string FullTableName => $"[{SchemaName}].[{TableName}]";

		[NotMapped]
		public string SchemaName { get; set; }

		[NotMapped]
		public string TableName { get; set; }

		[Hidden]
		public int ID { get; set; }
	}
}