﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.Services.Contracts;
using System;
using System.Linq;
using System.Net.Http;
using TestProject.Consts;
using WireMock.Server;

namespace TestProject
{
    public class CustomWebApplicationFactory<TStartup> :
            WebApplicationFactory<TStartup> where TStartup : class
    {
        public WireMockServer RateMockServer { get; }

        public HttpClient CreateAuthClient()
        {
            return WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                });
            })
            .CreateClient();
        }

        public CustomWebApplicationFactory()
        {
            RateMockServer = WireMockServer.Start();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Fake IS3Service service
                var rateDescriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(IRateService));

                services.Remove(rateDescriptor);

                var mock = new Mock<IRateService>();
                mock.Setup(x => x.GetRate())
                    .ReturnsAsync(0);

                var rate = mock.Object;
                services.AddSingleton(mock.Object);


                // Use InMemoryDb
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(DbContextOptions<ApplicationContext>));

                services.Remove(descriptor);

                services.AddDbContext<ApplicationContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                });

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<ApplicationContext>();
                    var logger = scopedServices
                        .GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

                    try
                    {
                        if (db.Database.EnsureCreated())
                        {
                            InitializeDbForTests(db);
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "An error occurred seeding the " +
                            "database with test messages. Error: {Message}", ex.Message);
                    }
                }

            });
            //.ConfigureAppConfiguration((hostingContext, config) =>
            //{
            //    // Comment line below to test against real Edaart
            //    // config.AddInMemoryCollection(configSettings);
            //});
        }

        public void InitializeDbForTests(ApplicationContext context)
        {
            context.Books.AddRange(Defaults.Books);
            context.SaveChanges();
        }
    }
}
