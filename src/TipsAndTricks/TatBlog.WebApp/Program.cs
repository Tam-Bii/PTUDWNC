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

var app = builder.Build();
{
    app.UseRequestPipeline();
    app.UseBlogRoutes();
    app.UseDataSeeder();

}

app.Run();
