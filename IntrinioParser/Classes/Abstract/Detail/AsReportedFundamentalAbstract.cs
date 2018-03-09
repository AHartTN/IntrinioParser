namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class AsReportedFundamentalAbstract : FundamentalAbstract
	{
		internal AsReportedFundamentalAbstract()
		{
			DataType = IntrinioDataType.AsReportedFundamentals;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}