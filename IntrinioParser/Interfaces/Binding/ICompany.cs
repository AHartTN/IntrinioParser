using IntrinioParser.Interfaces.Mapping.Single;

namespace IntrinioParser.Interfaces.Binding
{
	public interface ICompany : ICompanyMasterable
	{
		string Ticker { get; set; }
		string CIK { get; set; }
		string Name { get; set; }
		string LegalName { get; set; }
		string LEI { get; set; }
		string HQAddress1 { get; set; }
		string HQAddress2 { get; set; }
		string HQAddressCity { get; set; }
		string HQAddressPostalCode { get; set; }
		string EntityLegalForm { get; set; }
		string HQState { get; set; }
		string HQCountry { get; set; }
		string IncState { get; set; }
		string IncCountry { get; set; }
		string SIC { get; set; }
		string StockExchange { get; set; }
		string Template { get; set; }
		string ShortDescription { get; set; }
		string LongDescription { get; set; }
		string CEO { get; set; }
		string CompanyURL { get; set; }
		string BusinessAddress { get; set; }
		string MailingAddress { get; set; }
		string BusinessPhoneNo { get; set; }
		int? Employees { get; set; }
		string Sector { get; set; }
		string IndustryCategory { get; set; }
		string IndustryGroup { get; set; }
		bool? StandardizedActive { get; set; }
	}
}