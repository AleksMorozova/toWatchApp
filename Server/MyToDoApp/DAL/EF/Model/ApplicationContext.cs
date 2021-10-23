using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyToDoApp.DAL.Model;

namespace MyToDoApp.DAL.EF.Model
{
    public class ApplicationContext : DbContext
    {
        // public static readonly ILoggerFactory loggerFactory  = new LoggerFactory();

        public static readonly ILoggerFactory loggerFactory 
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<TVSeries> TVSerials { get; set; }
        public DbSet<TEDTalk> TEDTalks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLoggerFactory(loggerFactory)
            //    .EnableSensitiveDataLogging()
            //    .UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;");
            // optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;");

            // optionsBuilder.UseSqlServer(@"Server=mssqllocaldb;Database=ApplicationContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
