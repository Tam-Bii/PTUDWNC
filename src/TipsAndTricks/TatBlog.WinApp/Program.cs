using TatBlog.Data.Contexts;
using TatBlog.Data.Seeders;
using TatBlog.Services.Blogs;
using TatBlog.WinApp;


////Tạo đối tượng DBContext để quản lý phiên làm việc
//// với CSDL và trạng thái của đối tượng
//var context = new BlogDbContext();
//// Tạo đối tượng khởi tạo dữ liệu mẫu
//var seeders = new DataSeeder(context);
//// Gọi hàm initialize để nhập dữ liệu mẫu
//seeders.Initialize();
//// đọc danh sách tác giả từ csdl
//var authors = context.Authors.ToList();
//// Xuất danh sách tác giả ra màn hình
//Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12}", "ID", "Full Name", "Email", "Joined Date");
//foreach (var author in authors)
//{
//    Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12:MM/dd/yyyy}", author.Id, author.FullName, author.Email, author.JoinedDate);
//}


//------để đọc và hiển thị danh sách bài viết kèm theo tên chuyên mục, tác giả.-----
//// Tạo đối tượng DBContext để quản lý phiên làm việc
//// với CSDL và trạng thái của đối tượng
//var context = new BlogDbContext();
//// Đọc danh sách bài viết từ CSDL
//// Lấy kém tên tác giả và chuyên mục
//var posts = context.Posts
//    .Where(p => p.Published)
//    .OrderBy(p => p.Title)
//    .Select(p => new
//    {
//        Id = p.Id,
//        Title = p.Title,
//        ViewCount = p.ViewCount,
//        PostedDate = p.PostedDate,
//        Author = p.Author.FullName,
//        Category = p.Category.Name
//    })
//    .ToList();
////Xuất danh sách bài viết ra màn hình
//foreach (var post in posts)
//{
//    Console.WriteLine("ID               : {0}", post.Id);
//    Console.WriteLine("Title            : {0}", post.Title);
//    Console.WriteLine("ViewCount        : {0}", post.ViewCount);
//    Console.WriteLine("Date             : {0:MM/dd/yyyy}", post.PostedDate);
//    Console.WriteLine("Author           : {0}", post.Author);
//    Console.WriteLine("Category         : {0}", post.Category);
//    Console.WriteLine("".PadRight(80, '-'));
//}


//--------------------để xem hoạt động của các phương thức vừa định nghĩa------------------------
//// Tạo đối tượng DBContext để quản lý phiên làm việc
//// với CSDL và trạng thái của đối tượng
//var context = new BlogDbContext();
//// Tạo đối tượng BlogRepository
//IBlogRepository blogRepo = new BlogRepository(context);
//// Tìm 3 bài viết được xem/đọc nhiều nhất
//var posts = await blogRepo.GetPopularArticlesAsync(3);

//// Xuất danh sách bài viết ra màn hình
//foreach (var post in posts)
//{
//    Console.WriteLine("ID               : {0}", post.Id);
//    Console.WriteLine("Title            : {0}", post.Title);
//    Console.WriteLine("ViewCount        : {0}", post.ViewCount);
//    Console.WriteLine("Date             : {0:MM/dd/yyyy}", post.PostedDate);
//    Console.WriteLine("Author           : {0}", post.Author);
//    Console.WriteLine("Category         : {0}", post.Category);
//    Console.WriteLine("".PadRight(80, '-'));
//}


//----------------để kiểm tra kết quả của phương thức vừa tạo ----------------------------

//// tạo đối tượng dbcontext để quản lý phiên làm việc
//// với csdl và trạng thái của đối tượng
//var context = new BlogDbContext();
//// Tạo đối tượng BlogRepository
//IBlogRepository blogRepo = new BlogRepository(context);
//// Lấy danh sách chuyên mục
//var categories = await blogRepo.GetCategoriesAsync();

//Console.WriteLine("{0,-5}{1,-50}{2,10}",
//    "ID", "Name", "Cuont");

//// Xuất ra màn hình
//foreach (var item in categories)
//{
//    Console.WriteLine("{0,-5}{1,-50}{2,10}", item.Id, item.Name, item.PostCount);
//}


//----------------------------để gọi hàm và kiểm tra kết quả--------------------------------

// Tạo đối tượng DBContext để quản lý phiên làm việc
// với CSDL và trạng thái của đối tượng
var context = new BlogDbContext();
// Tạo đối tượng BlogRepository
IBlogRepository blogRepo = new BlogRepository(context);
var pagingParams = new PagingPrams
{
    PageNumber = 1, //Lấy kết quả ở trang số 1
    PageSize = 5, // Lấy 5 mẫu tin
    SortColumn = "Name", // Sắp xếp theo tên
    SortOrder = "DESC" // Theo chiều giảm dần
};
// Lấy danh sách từ khóa
var tagsList = await blogRepo.GetPagedTagsAsync(pagingParams);
// Xuất ra màn hình
Console.WriteLine("{0,-5}{1,-50}{2,10}", "ID", "Name", "Count");
foreach (var item in tagsList)
{
    Console.WriteLine("{0,-5}{1,-50}{2,10}", item.Id, item.Name, item.PostCount);
}
