namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Interfaces.Binding.Detail;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class BankDepositAbstract
		: BaseAbstract,
		  IBankDeposit
	{
		internal BankDepositAbstract()
		{
			//DataType = IntrinioDataType;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IBankDeposit
		[JsonProperty("")]
		public int BankBranchID { get; set; }

		[JsonProperty("")]
		public DateTime? ReportedDate { get; set; }

		[JsonProperty("")]
		public int? Year { get; set; }

		[JsonProperty("")]
		public decimal? TotalDeposits { get; set; }

		[JsonProperty("")]
		public BankBranch BankBranch { get; set; }
		#endregion
	}
}