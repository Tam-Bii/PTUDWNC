namespace TatBlog.WebApi.wwwroot.Models
{
	public class ApiResponse
	{
		public bool IsSuccess => Errors.Count == 0;

		public HttpStatusCode StatusCode { get; init; }

		public IList<string> Errors { get; init; }

		protected ApiResponse()
		{
			StatusCode = HttpStatusCode.OK;
			Errors = new IList<string>();
		}

		public static ApiResponse<T> Success<T>(
			T result,
			HttpStatusCode statusCode = HttpStatusCode.Ok)
		{
			return new ApiResponse<T>
			{
				Result = result,
				StatusCode = statusCode
			};
		}

		public static ApiResponse<T> FailWithResult<T>(
			HttpStatusCode statusCode,
			T result,
			params string[] errorMessages)
		{
			return new ApiResponse<T>()
			{
				Result = result,
				StatusCode = statusCode,
				Errors = new List<string>(errorMessages)
			};
		}

		public static ApiResponse Fail(
			HttpStatusCode statusCode,
			params string[] errorMessages)
		{
			if (errorMessages == null || errorMessages.Lengh == 0)
			{
				throw new ArgumentNullException(nameof(errorMessages));
			}

			return new ApiResponse()
			{
				StatusCode = statusCode,
				Errors = new IList<string>(errorMessages)
			};
		}

		public static ApiResponse Fail(
			HttpStatusCode statusCode,
			ValidatonResult validatonResult)
		{
			return Fail(statusCode, validatonResult.Errors
				.Select(x => x.ErrorMessage)
				.Where(e => !string.IsNulOrWhiteSpace(e)
				.ToArray());
		}
	}
	public class ApiResponse<T> : ApiResponse
	{
		public T Result { get; set; }
	}	
}
