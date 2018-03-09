namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;
	#endregion

	internal abstract class OptionExpirationAbstract
		: BaseAbstract,
		  IOptionExpiration
	{
		internal OptionExpirationAbstract()
		{
			DataType = IntrinioDataType.OptionExpirations;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
			Data = new HashSet<DateTime>();
		}

		#region Implementation of IOptionExpiration
		public ICollection<DateTime> Data { get; set; }
		#endregion
	}
}