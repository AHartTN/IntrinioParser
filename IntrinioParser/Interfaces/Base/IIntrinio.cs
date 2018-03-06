namespace IntrinioParser.Interfaces.Base
{
	#region
	using Enumerators;
	#endregion

	internal interface IIntrinio
	{
		IntrinioDataType DataType { get; }
		FileType FileType { get; }
	}
}