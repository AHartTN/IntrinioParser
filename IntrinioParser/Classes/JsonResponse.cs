namespace IntrinioParser.Classes
{
	#region
	using System.Collections.Generic;

	using Abstract.Base;

	using Newtonsoft.Json;
	#endregion

	internal sealed class JsonResponse<T>
		where T : BaseAbstract
	{
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