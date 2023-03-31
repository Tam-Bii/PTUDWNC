using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatBlog.Core.Contracts;
using TatBlog.Core.DTO;
using TatBlog.Core.Entities;

namespace TatBlog.Services.Blogs;

public class CategoryQuery 
{
	public string Keyword { get; set; }
	public string UrlSlug { get; set; }
	public bool ShowOnMenu { get; set; }
}