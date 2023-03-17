using TatBlog.WebApp.Mapsters;
using WebApp.Extensions;
using WebApp.Validations;


var builder = WebApplication.CreateBuilder(args);
{
    builder
        .ConfigureMvc()
        .ConfigureNlog()
        .ConfigureServices()
        .ConfigureMapster()
        .ConfigureFluentValidation();
}

//Thêm dữ liêu mẫu vào CSDL


var app = builder.Build();
{
    app.UseRequestPipeline();
    app.UseBlogRoutes();
    app.UseDataSeeder();

}


app.Run();
