namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class BankFinancialAbstract : FinancialAbstract
	{
		internal BankFinancialAbstract()
		{
			DataType = IntrinioDataType.BankFinancials;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}