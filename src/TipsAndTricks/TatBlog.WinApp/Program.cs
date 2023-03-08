using TatBlog.Data.Contexts;
using TatBlog.Data.Seeders;


//Tạo đối tượng DBContext để quản lý phiên làm việc
// với CSDL và trạng thái của đối tượng
var context = new BlogDbContext();
// Tạo đối tượng khởi tạo dữ liệu mẫu
var seeders = new DataSeeder(context);
// Gọi hàm initialize để nhập dữ liệu mẫu
seeders.Initialize();
// đọc danh sách tác giả từ csdl
var authors = context.Authors.ToList();
// Xuất danh sách tác giả ra màn hình
Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12}", "ID", "Full Name", "Email", "Joined Date");
foreach (var author in authors)
{
    Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12:MM/dd/yyyy}", author.Id, author.FullName, author.Email, author.JoinedDate);
}