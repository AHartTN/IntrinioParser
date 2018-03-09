namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class AsReportedTagAbstract : TagAbstract
	{
		internal AsReportedTagAbstract()
		{
			DataType = IntrinioDataType.AsReportedXBRLTagsAndLabels;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}