namespace IntrinioParser.Interfaces.Binding.Detail
{
	#region
	using System;
	#endregion

	public interface IHistoricalData
	{
		string Identifier { get; set; }
		string Item { get; set; }
		DateTime? Date { get; set; }
		object Value { get; set; }
	}
}