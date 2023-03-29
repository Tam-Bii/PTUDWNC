namespace TatBlog.WebApi.wwwroot.Models
{
	public class ValidationFailureResponse
	{
		public IEnumerable<string> Errors { get; set; }

		public ValidationFailureResponse(
			IEnumerable<string> errorMessages)
		{
			Errors = errorMessage;
		}
	}
}
