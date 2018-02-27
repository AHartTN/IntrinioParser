using System.Collections.Generic;
using Newtonsoft.Json;

namespace IntrinioParser.Classes
{
	public class JsonResponse<T> where T : class
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