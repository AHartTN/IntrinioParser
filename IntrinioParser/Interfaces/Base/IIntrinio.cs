using IntrinioParser.Enumerators;

namespace IntrinioParser.Interfaces.Base
{
	public interface IIntrinio : IBaseModel
	{
		DataType DataType { get; }
		FileType FileType { get; }
	}
}