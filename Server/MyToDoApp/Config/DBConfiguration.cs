using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyToDoApp.DAL.EF.Model;
using System.Data;
using System.Data.Common;

namespace MyToDoApp.Config
{
    public static class DBConfiguration
    {
        public static void AddDBConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ApplicationContext");

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddSingleton<DbConnectionStringBuilder>(new SqlConnectionStringBuilder
            {
                ConnectionString = connectionString
            });
            services.AddTransient<IDbConnection>(provider =>
            {
                DbProviderFactories.RegisterFactory("Microsoft.Data.SqlClient", SqlClientFactory.Instance);

                var builder = provider.GetRequiredService<DbConnectionStringBuilder>();
                var providerFactory = DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
                var conn = providerFactory.CreateConnection();
                conn.ConnectionString = builder.ConnectionString;
                return conn;
            });
        }
    }
}
