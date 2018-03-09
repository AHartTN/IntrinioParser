namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class CompanyFilingAbstract : FilingAbstract
	{
		internal CompanyFilingAbstract()
		{
			DataType = IntrinioDataType.CompanySECFilings;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}