namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;
	using System.Collections.Generic;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Models.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class BankBranchAbstract
		: BaseAbstract,
		  IBankBranch
	{
		internal BankBranchAbstract()
		{
			DataType = IntrinioDataType.BankBranches;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
			Deposits = new HashSet<BankDeposit>();
		}

		#region Implementation of IBankBranch
		[JsonProperty("")]
		public int? RSSDID { get; set; }

		[JsonProperty("")]
		public string BankName { get; set; }

		[JsonProperty("")]
		public int? UniNumber { get; set; }

		[JsonProperty("")]
		public int? BranchNumber { get; set; }

		[JsonProperty("")]
		public string BranchName { get; set; }

		[JsonProperty("")]
		public string Address { get; set; }

		[JsonProperty("")]
		public string City { get; set; }

		[JsonProperty("")]
		public string State { get; set; }

		[JsonProperty("")]
		public string ZipCode { get; set; }

		[JsonProperty("")]
		public string County { get; set; }

		[JsonProperty("")]
		public string Country { get; set; }

		[JsonProperty("")]
		public int? StateNo { get; set; }

		[JsonProperty("")]
		public int? StateAndCountyNo { get; set; }

		[JsonProperty("")]
		public string CentralCity { get; set; }

		[JsonProperty("")]
		public decimal? Latitude { get; set; }

		[JsonProperty("")]
		public decimal? Longitude { get; set; }

		[JsonProperty("")]
		public string LocationQuality { get; set; }

		[JsonProperty("")]
		public string LocationMethod { get; set; }

		[JsonProperty("")]
		public int? PlaceNum { get; set; }

		[JsonProperty("")]
		public BranchServiceType BranchServiceType { get; set; }

		[JsonProperty("")]
		public bool? MainOffice { get; set; }

		[JsonProperty("")]
		public int? MSANo { get; set; }

		[JsonProperty("")]
		public string MSA { get; set; }

		[JsonProperty("")]
		public int? CSANo { get; set; }

		[JsonProperty("")]
		public string CSA { get; set; }

		[JsonProperty("")]
		public int? CBSANo { get; set; }

		[JsonProperty("")]
		public string CBSA { get; set; }

		[JsonProperty("")]
		public int? CBSADivisionNo { get; set; }

		[JsonProperty("")]
		public string CBSADivision { get; set; }

		[JsonProperty("")]
		public DateTime? EstablishedOn { get; set; }

		[JsonProperty("")]
		public DateTime? AcquiredOn { get; set; }

		[JsonProperty("")]
		public ICollection<BankDeposit> Deposits { get; set; }
		#endregion
	}
}