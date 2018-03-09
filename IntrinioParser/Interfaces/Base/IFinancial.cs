namespace IntrinioParser.Interfaces.Base
{
	internal interface IFinancial : IBaseModel
	{
		string Tag { get; set; }
		string XBRLTag { get; set; }
		string DomainTag { get; set; }
		object Value { get; set; }
	}
}