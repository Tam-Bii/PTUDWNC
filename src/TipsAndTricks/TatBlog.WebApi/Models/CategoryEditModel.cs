namespace TatBlog.WebApi.Models;

public class CategoryEditModel
{
	public string name { get; set; }

	public string UrlSlug { get; set; }

	public string Description { get; set; }

	public bool ShowOnMenu { get; set; }
}
