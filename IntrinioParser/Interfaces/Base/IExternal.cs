namespace IntrinioParser.Interfaces.Base
{
	internal interface IExternal : IBaseModel
	{
		int? IntrinioID { get; set; }
		string Source { get; set; }
		string ExternalID { get; set; }
	}
}