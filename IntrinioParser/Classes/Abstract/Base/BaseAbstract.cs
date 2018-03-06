namespace IntrinioParser.Classes.Abstract.Base
{
	#region
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	using Attributes;

	using Enumerators;

	using Interfaces.Base;
	#endregion

	internal abstract class BaseAbstract : IBaseModel
	{
		[NotMapped]
		public string FullTableName => $"[{SchemaName}].[{TableName}]";

		#region Implementation of IIdentifiable
		[Hidden]
		[Key]
		public int ID { get; set; }

		[NotMapped]
		public string SchemaName { get; set; }

		[NotMapped]
		public string TableName { get; set; }
		#endregion

		#region Implementation of IIntrinio
		[NotMapped]
		public IntrinioDataType DataType { get; internal set; }

		[NotMapped]
		public FileType FileType { get; } = FileType.CSV;
		#endregion
	}
}