using System.ComponentModel.DataAnnotations.Schema;
using IntrinioParser.Attributes;
using IntrinioParser.Interfaces.Base;

namespace IntrinioParser.Models.Abstract
{
	public abstract class BaseAbstract : IBaseModel
	{
		[NotMapped]
		public string SchemaName { get; set; }

		[NotMapped]
		public string TableName { get; set; }

		[NotMapped]
		public string FullTableName => $"[{SchemaName}].[{TableName}]";

		[Hidden]
		public int ID { get; set; }
	}
}