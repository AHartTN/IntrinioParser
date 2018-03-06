namespace IntrinioParser.Classes
{
	#region
	using System.Collections.Generic;
	using System.Security;

	using Abstract.Base;

	using Newtonsoft.Json;
	#endregion

	internal sealed class JsonResponse<T>
		where T : BaseAbstract
	{
		[JsonProperty("identifier")]
		public string Identifier { get; set; }
		[JsonProperty("item")]
		public string Item { get; set; }
		[JsonProperty("result_count")]
		public int ResultCount { get; set; }

		[JsonProperty("page_size")]
		public int PageSize { get; set; }

		[JsonProperty("current_page")]
		public int CurrentPage { get; set; }

		[JsonProperty("total_pages")]
		public int TotalPages { get; set; }

		[JsonProperty("api_call_credits")]
		public int APICallCredits { get; set; }

		public IReadOnlyCollection<T> Data { get; set; }
	}
}