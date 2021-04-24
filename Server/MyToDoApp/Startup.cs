using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyToDoApp.Service;
using EF;
using MyToDoApp.Repositories;
using MyToDoApp.Repositories_EF;
using MyToDoApp.Repositories_Dapper;
using Microsoft.OpenApi.Models;

namespace MyToDoApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "My API",
                Version = "v1"
            }));

            // Services
            services.AddScoped<IMoviesService, MoviesService>();
            services.AddScoped<ITVSeriesService, TVSeriesService>();
            services.AddScoped<IBooksService, BooksService>();
            services.AddScoped<ITedTalksService, TedTalksService>();

            // Repositories
            services.AddScoped<IMoviesRepository, MoviesRepositoryDapper>();
            services.AddScoped<ITVSeriesRepository, TVSeriesRepositoryEF>();
            services.AddScoped<IBooksRepository, BooksRepositoryEF>();
            services.AddScoped<ITedTalksRepository, TedTalksRepositoryEF>();

            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ApplicationContext")));
            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=all}");
            });
            app.UseDeveloperExceptionPage();
            SwaggerConfig(app);
        }

        private void SwaggerConfig(IApplicationBuilder app)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Test1 Api v1");
                // c.InjectStylesheet("/StyleSheet1.css");
            });
        }
    }
}
