namespace IntrinioParser.Classes.Abstract.Master
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Master;
	#endregion

	internal abstract class PressReleaseMasterAbstract
		: BaseAbstract,
		  IPressReleaseMaster
	{
		internal PressReleaseMasterAbstract()
		{
			DataType = IntrinioDataType.PressReleases;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IPressReleaseMaster
		public string Ticker { get; set; }
		public string FIGITicker { get; set; }
		public string FIGI { get; set; }
		public string IssuerName { get; set; }
		public string Title { get; set; }
		public DateTime? PublicationDate { get; set; }
		public string Url { get; set; }
		public string Summary { get; set; }
		#endregion
	}
}