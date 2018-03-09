namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class StandardizedFinancialAbstract : FinancialAbstract
	{
		internal StandardizedFinancialAbstract()
		{
			DataType = IntrinioDataType.StandardizedFinancials;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}