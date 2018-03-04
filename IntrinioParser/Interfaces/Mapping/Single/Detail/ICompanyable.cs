namespace IntrinioParser.Interfaces.Mapping.Single.Detail
{
	#region
	using Models.Binding.Detail;
	#endregion

	internal interface ICompanyable
	{
		int CompanyID { get; set; }
		Company Company { get; set; }
	}
}