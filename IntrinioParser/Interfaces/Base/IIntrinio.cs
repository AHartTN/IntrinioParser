using IntrinioParser.Enumerators;

namespace IntrinioParser.Interfaces.Base
{
	public interface IIntrinio
	{
		DataType DataType { get; }
		FileType FileType { get; }
	}
}