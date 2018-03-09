namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class AsReportedFinancialAbstract : FinancialAbstract
	{
		internal AsReportedFinancialAbstract()
		{
			DataType = IntrinioDataType.AsReportedFinancials;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}