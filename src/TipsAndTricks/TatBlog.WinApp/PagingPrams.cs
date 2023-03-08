using TatBlog.Core.Contracts;

namespace TatBlog.WinApp;

public class PagingPrams : IPagingParams
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string SortColumn { get; set; } = "Id";
    public string SortOrder { get; set; } = "ASC";
}