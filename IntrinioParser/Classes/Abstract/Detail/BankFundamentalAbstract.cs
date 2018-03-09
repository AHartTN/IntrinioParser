namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class BankFundamentalAbstract : FundamentalAbstract
	{
		internal BankFundamentalAbstract()
		{
			DataType = IntrinioDataType.BankFundamentals;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}