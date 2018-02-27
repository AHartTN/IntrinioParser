namespace IntrinioParser.Interfaces.Base
{
	public interface IIdentifiable
	{
		string SchemaName { get; set; }
		string TableName { get; set; }
		int ID { get; set; }
	}
}