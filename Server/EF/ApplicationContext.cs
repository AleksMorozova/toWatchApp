using EF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<TVSeries> TVSerials { get; set; }
        public DbSet<TEDTalk> TEDTalks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;");

            // optionsBuilder.UseSqlServer(@"Server=mssqllocaldb;Database=ApplicationContext;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
