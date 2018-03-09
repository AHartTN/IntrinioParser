namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class InstitutionalOwnerAbstract
		: BaseAbstract,
		  IInstitutionalOwner
	{
		internal InstitutionalOwnerAbstract()
		{
			DataType = IntrinioDataType.InstitutionalOwnersBySecurity;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IInstitutionalOwner
		[JsonProperty("")]
		public string OwnerCIK { get; set; }

		[JsonProperty("")]
		public string OwnerName { get; set; }

		[JsonProperty("")]
		public DateTime? PeriodEnded { get; set; }

		[JsonProperty("")]
		public decimal? Value { get; set; }

		[JsonProperty("")]
		public decimal? Amount { get; set; }

		[JsonProperty("")]
		public decimal? SoleVotingAuthority { get; set; }

		[JsonProperty("")]
		public decimal? SharedVotingAuthority { get; set; }

		[JsonProperty("")]
		public decimal? NoVotingAuthority { get; set; }

		[JsonProperty("")]
		public decimal? PrevAmount { get; set; }

		[JsonProperty("")]
		public decimal? AmountChg { get; set; }

		[JsonProperty("")]
		public decimal? AmountPctChg { get; set; }
		#endregion
	}
}