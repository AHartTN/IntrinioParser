using CsvHelper.Configuration;
using IntrinioParser.Models.Binding.Detail;

namespace IntrinioParser.Mapping.CSV.Detail
{
	internal sealed class CompanyCSVMap : ClassMap<Company>
	{
		public CompanyCSVMap()
		{
			Map(m => m.Ticker).Name("TICKER").NameIndex(0).Default(null);
			Map(m => m.CIK).Name("CIK").NameIndex(0).Default(null);
			Map(m => m.Name).Name("NAME").NameIndex(0).Default(null);
			Map(m => m.LegalName).Name("LEGAL_NAME").NameIndex(0).Default(null);
			Map(m => m.LEI).Name("LEI").NameIndex(0).Default(null);
			Map(m => m.HQAddress1).Name("HQ_ADDRESS1").NameIndex(0).Default(null);
			Map(m => m.HQAddress2).Name("HQ_ADDRESS2").NameIndex(0).Default(null);
			Map(m => m.HQAddressCity).Name("HQ_ADDRESS_CITY").NameIndex(0).Default(null);
			Map(m => m.HQAddressPostalCode).Name("HQ_ADDRESS_POSTAL_CODE").NameIndex(0).Default(null);
			Map(m => m.EntityLegalForm).Name("ENTITY_LEGAL_FORM").NameIndex(0).Default(null);
			Map(m => m.HQState).Name("HQ_STATE").NameIndex(0).Default(null);
			Map(m => m.HQCountry).Name("HQ_COUNTRY").NameIndex(0).Default(null);
			Map(m => m.IncState).Name("INC_STATE").NameIndex(0).Default(null);
			Map(m => m.IncCountry).Name("INC_COUNTRY").NameIndex(0).Default(null);
			Map(m => m.SIC).Name("SIC").NameIndex(0).Default(null);
			Map(m => m.StockExchange).Name("STOCK_EXCHANGE").NameIndex(0).Default(null);
			Map(m => m.Template).Name("TEMPLATE").NameIndex(0).Default(null);
			Map(m => m.ShortDescription).Name("SHORT_DESCRIPTION").NameIndex(0).Default(null);
			Map(m => m.LongDescription).Name("LONG_DESCRIPTION").NameIndex(0).Default(null);
			Map(m => m.CEO).Name("CEO").NameIndex(0).Default(null);
			Map(m => m.CompanyURL).Name("COMPANY_URL").NameIndex(0).Default(null);
			Map(m => m.BusinessAddress).Name("BUSINESS_ADDRESS").NameIndex(0).Default(null);
			Map(m => m.MailingAddress).Name("MAILING_ADDRESS").NameIndex(0).Default(null);
			Map(m => m.BusinessPhoneNo).Name("BUSINESS_PHONE_NO").NameIndex(0).Default(null);
			Map(m => m.Employees).Name("EMPLOYEES").NameIndex(0);
			Map(m => m.Sector).Name("SECTOR").NameIndex(0).Default(null);
			Map(m => m.IndustryCategory).Name("INDUSTRY_CATEGORY").NameIndex(0).Default(null);
			Map(m => m.IndustryGroup).Name("INDUSTRY_GROUP").NameIndex(0).Default(null);
			Map(m => m.StandardizedActive).Name("STANDARDIZED_ACTIVE").NameIndex(0);
		}
	}
}