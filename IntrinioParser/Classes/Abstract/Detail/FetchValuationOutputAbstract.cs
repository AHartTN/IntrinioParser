namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class FetchValuationOutputAbstract : ValuationAssumptionAbstract
	{
		internal FetchValuationOutputAbstract()
		{
			DataType = IntrinioDataType.FetchValuationOutputs;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}