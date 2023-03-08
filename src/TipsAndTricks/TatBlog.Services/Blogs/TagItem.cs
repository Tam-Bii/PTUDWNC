namespace TatBlog.Services.Blogs
{
    public class TagItem
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string UrlSlug { get; internal set; }
        public string Description { get; internal set; }
        public int PostCount { get; internal set; }
    }
}