using System;
using System.Collections.Generic;
using System.Linq;
using IntrinioParser.Helpers;
using IntrinioParser.Models.Binding;

namespace IntrinioParser
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Dictionary<string, string> arguments = new Dictionary<string, string> {{"ticker", "MSFT"}};

			IntrinioHelper intrinio = new IntrinioHelper();
			//IReadOnlyCollection<CompanyMaster> companyMasters = intrinio.Get<CompanyMaster>();
			//Company company = intrinio.Get<Company>(arguments).First();
			//IReadOnlyCollection<SecurityMaster> securityMasters = intrinio.Get<SecurityMaster>();
			//Security security = intrinio.Get<Security>(arguments).First();
			IReadOnlyCollection<IndexMaster> indexMasters = intrinio.Get<IndexMaster>();
			Console.ReadKey();
		}
	}
}