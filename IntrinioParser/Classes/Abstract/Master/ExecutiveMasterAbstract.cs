namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;
	#endregion

	internal abstract class ExecutiveMasterAbstract
		: BaseAbstract,
		  IExecutiveMaster
	{
		internal ExecutiveMasterAbstract()
		{
			DataType = IntrinioDataType.Executives;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IExecutiveMaster
		public string Identifier { get; set; }
		public string FullName { get; set; }
		public string Type { get; set; }
		#endregion
	}
}