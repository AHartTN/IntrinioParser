namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class FailedBankAbstract : FilingAbstract
	{
		internal FailedBankAbstract()
		{
			DataType = IntrinioDataType.FailedBanks;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}