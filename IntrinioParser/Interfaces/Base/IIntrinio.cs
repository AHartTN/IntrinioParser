namespace IntrinioParser.Interfaces.Base
{
	#region
	using Enumerators;
	#endregion

	internal interface IIntrinio
	{
		DataType DataType { get; }
		FileType FileType { get; }
	}
}