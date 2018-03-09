namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using Master;
	#endregion

	internal interface IExecutive : IExecutiveMaster
	{
		string Prefix { get; set; }
		string FirstName { get; set; }
		string MiddleName { get; set; }
		string LastName { get; set; }
		string NickName { get; set; }
		string Suffix { get; set; }
		string Gender { get; set; }
		int? Age { get; set; }
		int? AgeAsOnDate { get; set; }
		string ContactStatus { get; set; }
	}
}