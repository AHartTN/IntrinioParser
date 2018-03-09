namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class BankTagAbstract : TagAbstract
	{
		internal BankTagAbstract()
		{
			DataType = IntrinioDataType.BankXBRLTagsAndLabels;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}