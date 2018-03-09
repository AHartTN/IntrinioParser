namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;
	#endregion

	internal abstract class SecuritySearchAbstract
		: BaseAbstract,
		  ISecuritySearch
	{
		internal SecuritySearchAbstract()
		{
			DataType = IntrinioDataType.SecuritiesSearch;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}
	}
}