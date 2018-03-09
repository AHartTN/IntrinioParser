namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class ChangeValuationAssumptionAbstract : ValuationAssumptionAbstract
	{
		internal ChangeValuationAssumptionAbstract()
		{
			DataType = IntrinioDataType.ChangeValuationAssumptions;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}