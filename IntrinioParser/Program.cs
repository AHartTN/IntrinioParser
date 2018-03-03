using System;
using System.Collections.Generic;
using IntrinioParser.Helpers;
using IntrinioParser.Models.Binding.Detail;
using IntrinioParser.Models.Binding.Master;

namespace IntrinioParser
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Dictionary<string, string> arguments = new Dictionary<string, string>
			{
				{"ticker", "MSFT"}
			};

			IntrinioHelper intrinio = new IntrinioHelper();
			IReadOnlyCollection<CompanyMaster> companyMasters = intrinio.Get<CompanyMaster>();
			IReadOnlyCollection<Company> companies = intrinio.Get<Company>(arguments);
			IReadOnlyCollection<SecurityMaster> securityMasters = intrinio.Get<SecurityMaster>();
			IReadOnlyCollection<Security> securities = intrinio.Get<Security>(arguments);

			arguments = new Dictionary<string, string>
			{
				{"identifier", ""}
			};

			IReadOnlyCollection<IndexMaster> indexMasters = intrinio.Get<IndexMaster>();
			IReadOnlyCollection<Index> indices = intrinio.Get<Index>(arguments);
			
			arguments = new Dictionary<string, string>
			{
				{"identifier", ""}
			};

			IReadOnlyCollection<OwnerMaster> ownerMasters = intrinio.Get<OwnerMaster>();
			IReadOnlyCollection<Owner> owners = intrinio.Get<Owner>();


			arguments = new Dictionary<string, string>
			{
				{"identifier", ""}
			};

			IReadOnlyCollection<StockExchangeMaster> StockExchangeMasters = intrinio.Get<StockExchangeMaster>();
			IReadOnlyCollection<StockExchange> stockExchanges = intrinio.Get<StockExchange>();

			Console.ReadKey();
		}
	}
}