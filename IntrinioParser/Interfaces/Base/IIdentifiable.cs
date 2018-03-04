namespace IntrinioParser.Interfaces.Base
{
	internal interface IIdentifiable
	{
		int ID { get; set; }
		string SchemaName { get; set; }
		string TableName { get; set; }
	}
}