namespace IntrinioParser.Interfaces.Mapping.Single.Master
{
	#region
	using Models.Binding.Master;
	#endregion

	internal interface ICompanyMasterable
	{
		int CompanyMasterID { get; set; }
		CompanyMaster CompanyMaster { get; set; }
	}
}