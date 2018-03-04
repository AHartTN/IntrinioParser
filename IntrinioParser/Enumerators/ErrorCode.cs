namespace IntrinioParser.Enumerators
{
	internal enum ErrorCode
	{
		OK = 200,
		Unauthorized = 401,
		Forbidden = 403,
		NotFound = 404,
		TooManyRequests = 429,
		InternalServerError = 500,
		ServiceUnavailable = 503
	}
}