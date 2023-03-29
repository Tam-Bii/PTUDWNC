namespace TatBlog.WebApi.wwwroot.Extensions
{
	public class ValidationResultExtensions ToResponse(
		this ValidationResult validationResult)
	{
		return validationResult.Errors.ToResponse();
	}

	public static ValidationFailureResponse ToResponse(
		this IEnumerable<ValidationFailure> failures)
	{
		return new ValidationFailureResponse(
			failures.Select(e => e.ErrorMessage));
	}

	public static IList<string> GetErrorMessages(
		this ValidationResult validationResult)
	{
		return validationResult.Errors.GetErrorMessages();
	}
	public static IDictionary<string>, List<string>> GetErrorsWithProperyNames(
		this IEnumerable<ValidationFailure> failures)
	{
		return failures
			.GruopBy(e => e.PropertyName)
			.ToDictionary(
				g => g.Key,
				g => g.Select(e => e.ErrorMessage).ToList());
	}
}
