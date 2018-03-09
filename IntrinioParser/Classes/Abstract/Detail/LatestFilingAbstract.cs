namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class LatestFilingAbstract : FilingAbstract
	{
		internal LatestFilingAbstract()
		{
			DataType = IntrinioDataType.LatestSECFilings;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}