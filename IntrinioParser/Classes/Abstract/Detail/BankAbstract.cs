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

	internal abstract class BankAbstract
		: BaseAbstract,
		  IBank
	{
		internal BankAbstract()
		{
			DataType = IntrinioDataType.Banks;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
			BankHolding = new HashSet<BankHolding>();
		}

		#region Implementation of IBank
		[JsonProperty("")]
		public string RSSDID { get; set; }

		[JsonProperty("")]
		public string Name { get; set; }

		[JsonProperty("")]
		public string FDICCertificateNumber { get; set; }

		[JsonProperty("")]
		public bool? Form31Filter { get; set; }

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
		public string StateAndCountyNo { get; set; }

		[JsonProperty("")]
		public int? StateNo { get; set; }

		[JsonProperty("")]
		public string Url { get; set; }

		[JsonProperty("")]
		public int? TotalBranches { get; set; }

		[JsonProperty("")]
		public int? DomesticBranches { get; set; }

		[JsonProperty("")]
		public int? ForeignBranches { get; set; }

		[JsonProperty("")]
		public string AssetConcentration { get; set; }

		[JsonProperty("")]
		public AssetConcentration? AssetConcentrationNo { get; set; }

		[JsonProperty("")]
		public int? OCCCharterNumber { get; set; }

		[JsonProperty("")]
		public int? FDICGeoRegionNo { get; set; }

		[JsonProperty("")]
		public string FDICSupervisoryRegion { get; set; }

		[JsonProperty("")]
		public int? FDICSupervisoryRegionNo { get; set; }

		[JsonProperty("")]
		public string FRBDistrict { get; set; }

		[JsonProperty("")]
		public FRBDistrict? FRBDistrictNo { get; set; }

		[JsonProperty("")]
		public int? OTSDistrictNo { get; set; }

		[JsonProperty("")]
		public string OTSDistrict { get; set; }

		[JsonProperty("")]
		public int? OCCDistrictNo { get; set; }

		[JsonProperty("")]
		public string Regulator { get; set; }

		[JsonProperty("")]
		public bool? StateCharter { get; set; }

		[JsonProperty("")]
		public bool? FederalCharter { get; set; }

		[JsonProperty("")]
		public string FDICFieldOffice { get; set; }

		[JsonProperty("")]
		public BankClass BankClass { get; set; }

		[JsonProperty("")]
		public string CharteringAgency { get; set; }

		[JsonProperty("")]
		public bool? Conservatorship { get; set; }

		[JsonProperty("")]
		public bool? InterstateBranches { get; set; }

		[JsonProperty("")]
		public bool? SCorp { get; set; }

		[JsonProperty("")]
		public bool? TrustFiduciaryServices { get; set; }

		[JsonProperty("")]
		public bool? CommunityBank { get; set; }

		[JsonProperty("")]
		public int? CMSANo { get; set; }

		[JsonProperty("")]
		public string CMSA { get; set; }

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
		public int? CBSAMetroNo { get; set; }

		[JsonProperty("")]
		public string CBSAMetro { get; set; }

		[JsonProperty("")]
		public int? CBSADivisionNo { get; set; }

		[JsonProperty("")]
		public string CBSADivision { get; set; }

		[JsonProperty("")]
		public DateTime? LastUpdate { get; set; }

		[JsonProperty("")]
		public DateTime? LastStructuralChange { get; set; }

		[JsonProperty("")]
		public DateTime? EstablishedDate { get; set; }

		[JsonProperty("")]
		public DateTime? DepositInsuranceDate { get; set; }

		[JsonProperty("")]
		public bool? Active { get; set; }

		[JsonProperty("")]
		public ICollection<BankHolding> BankHolding { get; set; }
		#endregion
	}
}