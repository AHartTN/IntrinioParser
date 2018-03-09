namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class StandardizedTagAbstract : TagAbstract
	{
		internal StandardizedTagAbstract()
		{
			DataType = IntrinioDataType.StandardizedTagsAndLabels;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}