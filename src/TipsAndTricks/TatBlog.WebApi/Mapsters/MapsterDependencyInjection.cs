using Mapster;
using MapsterMapper;
using System.Runtime.CompilerServices;

namespace TatBlog.WebApi.Mapsters
{
	public static class MapsterDependencyInjection
	{ 
		public static WebApplicationBuilder ConfigureMapster(
		this WebApplicationBuilder builder1)
		{
			var config = TypeAdapterConfig.GlobalSettings;
			config.Scan(typeof(MapsterConfiguration).Assembly);

			builder1.Services.AddSingleton(config);
			builder1.Services.AddScoped<IMapper, ServiceMapper>();

			return builder1;
	}
	}
}
