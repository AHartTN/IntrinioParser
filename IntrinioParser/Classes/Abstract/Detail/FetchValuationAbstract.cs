namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class FetchValuationAbstract : ValuationAbstract
	{
		internal FetchValuationAbstract()
		{
			DataType = IntrinioDataType.FetchValuation;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}