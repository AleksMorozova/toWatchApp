using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace MyToDoApp.Config
{
    public static class SwaggerConfigurationService
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1"
                });
            });
        }
    }
}
