namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class ExecutiveRoleAbstract
		: BaseAbstract,
		  IExecutiveRole
	{
		internal ExecutiveRoleAbstract()
		{
			DataType = IntrinioDataType.ExecutiveRoles;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IExecutiveRole
		[JsonProperty("")]
		public string RoleName { get; set; }

		[JsonProperty("")]
		public string Company { get; set; }

		[JsonProperty("")]
		public string Ticker { get; set; }

		[JsonProperty("")]
		public string FIGITicker { get; set; }

		[JsonProperty("")]
		public string FIGI { get; set; }

		[JsonProperty("")]
		public string Status { get; set; }

		[JsonProperty("")]
		public DateTime? EffectiveDate { get; set; }

		[JsonProperty("")]
		public string Division { get; set; }

		[JsonProperty("")]
		public bool? ExecutiveDirector { get; set; }

		[JsonProperty("")]
		public bool? IndependentDirector { get; set; }
		#endregion
	}
}