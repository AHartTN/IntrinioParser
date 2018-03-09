namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System;
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;

	using Models.Binding.Detail;
	#endregion

	internal abstract class CompanyMasterAbstract
		: BaseAbstract,
		  ICompanyMaster
	{
		internal CompanyMasterAbstract()
		{
			DataType = IntrinioDataType.Companies;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Master";
			Companies = new HashSet<Company>();
		}

		#region Implementation of ICompaniesable
		public ICollection<Company> Companies { get; set; }
		#endregion

		#region Implementation of ICompanyMaster
		public string Ticker { get; set; }
		public string CIK { get; set; }
		public string LEI { get; set; }
		public string Name { get; set; }
		public DateTime? LatestFilingDate { get; set; }
		#endregion
	}
}