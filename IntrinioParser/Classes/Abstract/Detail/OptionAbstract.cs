namespace IntrinioParser.Classes.Abstract.Detail
{
	#region
	using System;

	using Base;

	using Enumerators;

	using Interfaces.Binding.Detail;

	using Newtonsoft.Json;
	#endregion

	internal abstract class OptionAbstract
		: BaseAbstract,
		  IOption
	{
		internal OptionAbstract()
		{
			DataType = IntrinioDataType.Options;
			//FileType = FileType.CSV;
			SchemaName = DataType.ToString();
			TableName = "Information";
		}

		#region Implementation of IOption
		[JsonProperty("")]
		public DateTime? Date { get; set; }

		[JsonProperty("")]
		public DateTime? Expiration { get; set; }

		[JsonProperty("")]
		public decimal? Strike { get; set; }

		[JsonProperty("")]
		public string Type { get; set; }

		[JsonProperty("")]
		public decimal? Close { get; set; }

		[JsonProperty("")]
		public decimal? CloseBid { get; set; }

		[JsonProperty("")]
		public decimal? CloseAsk { get; set; }

		[JsonProperty("")]
		public decimal? Volume { get; set; }

		[JsonProperty("")]
		public decimal? VolumeBid { get; set; }

		[JsonProperty("")]
		public decimal? VolumeAsk { get; set; }

		[JsonProperty("")]
		public decimal? Trades { get; set; }

		[JsonProperty("")]
		public decimal? OpenInterest { get; set; }

		[JsonProperty("")]
		public decimal? OpenInterestChange { get; set; }

		[JsonProperty("")]
		public decimal? NextDayOpenInterest { get; set; }

		[JsonProperty("")]
		public decimal? ImpliedVolatility { get; set; }

		[JsonProperty("")]
		public decimal? ImpliedVolatilityChange { get; set; }

		[JsonProperty("")]
		public decimal? Delta { get; set; }
		#endregion
	}
}