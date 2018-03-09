namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Enumerators;
	#endregion

	internal abstract class CreateValuationAbstract : ValuationAbstract
	{
		internal CreateValuationAbstract()
		{
			DataType = IntrinioDataType.CreateValuation;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}