namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class FetchValuationAssumptionAbstract : ValuationAssumptionAbstract
	{
		internal FetchValuationAssumptionAbstract()
		{
			DataType = IntrinioDataType.FetchValuationAssumptions;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}