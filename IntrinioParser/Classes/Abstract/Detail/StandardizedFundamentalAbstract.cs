namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class StandardizedFundamentalAbstract : FundamentalAbstract
	{
		internal StandardizedFundamentalAbstract()
		{
			DataType = IntrinioDataType.StandardizedFundamentals;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}