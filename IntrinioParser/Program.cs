namespace IntrinioParser
{
	#region
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;

	using Helpers;

	using Models.Binding.Detail;
	using Models.Binding.Master;
	#endregion

	internal static class Program
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
							{"symbol", "$A054RC1Q027SBEA"}
						};

			IReadOnlyCollection<IndexMaster> indexMasters = intrinio.Get<IndexMaster>();
			IReadOnlyCollection<Index> indices = intrinio.Get<Index>(arguments);
			IReadOnlyCollection<OwnerMaster> ownerMasters = intrinio.Get<OwnerMaster>();
			IReadOnlyCollection<StockExchangeMaster> StockExchangeMasters = intrinio.Get<StockExchangeMaster>();

			Console.ReadKey();
		}
	}
}