namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class BankHoldingAbstract
		: BaseAbstract,
		  IBankHolding
	{
		internal BankHoldingAbstract()
		{
			DataType = IntrinioDataType.BankHoldingCompanies;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
			Banks = new HashSet<Bank>();
		}

		#region Implementation of IBankHolding
		[JsonProperty("")]
		public int RSSDID { get; set; }

		[JsonProperty("")]
		public string Name { get; set; }

		[JsonProperty("")]
		public string City { get; set; }

		[JsonProperty("")]
		public string State { get; set; }

		[JsonProperty("")]
		public ICollection<Bank> Banks { get; set; }
		#endregion
	}
}