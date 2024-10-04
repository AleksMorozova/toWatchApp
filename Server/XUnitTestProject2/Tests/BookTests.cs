using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using MyToDoApp;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.DAL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TestProject.Consts;
using Moq;
using MyToDoApp.Services.Contracts;
using WireMock.Server;
using WireMock.RequestBuilders;

namespace TestProject.Tests
{
    [Collection("Test server")]
    public class BookTests
    {
        private readonly HttpClient client;
        private readonly IServiceScope serviceScope;
        private readonly ApplicationContext context;
        private readonly WireMockServer rateMockServer;

        public BookTests(CustomWebApplicationFactory<Startup> factory)
        {
            rateMockServer = factory.RateMockServer;
            client = factory.CreateAuthClient();
            serviceScope = factory.Services.CreateScope();
            context = serviceScope.ServiceProvider.GetRequiredService<ApplicationContext>();
        }

        [Fact]
        public async Task Should_get_all_books()
        {
            // Arrange
            var books = Defaults.Books;

            // Act
            var response = await client.GetAsync($"Books/all");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var booksResult = await response.BodyAs<List<Book>>();
            booksResult.Count.Should().Be(1);
            // booksResult.Should().BeEquivalentTo(books);
        }

        [Fact]
        public async Task Should_get_book_by_id()
        {
            // Arrange
            var book = Defaults.Books[0];

            //var mock = new Mock<IRateService>();
            //mock.Setup(x => x.GetRate())
            //    .ReturnsAsync(0);

            //var repository = mock.Object;
            //var service = new CustomerService(repository);
            //var result = service.GetCustomerById(customerId);

            // Act
            var response = await client.GetAsync($"Books/8fc22b4c-ffed-4f5e-abe2-6bfe98a54c07");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var bookResult = await response.BodyAs<Book>();
            bookResult.Title.Should().BeEquivalentTo(book.Title);
        }

        [Fact]
        public async Task Should_add_book()
        {
            // Arrange
            var book = new Book
            {
                ID = new Guid("8fc22b4c-ffed-4f5e-abe2-6bfe98a54c01"),
                Title = "Book_2",
                //Author = new Author { ID = new Guid("8fc22b4c-ffed-4f5e-abe2-6bfe98a54c22"), Name = "Author_2" },
                Description = "Test2",
                IsReaded = false
            };

            // Act
            var json = JsonConvert.SerializeObject(book);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await client.PostAsync($"Books", stringContent);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var booksCount = context.Books.ToList().Count;
            booksCount.Should().Be(2);
        }
        [Fact]
        public async Task Should_read_book()
        {
            // Arrange
            var book = Defaults.Books[0];

            // Act
            var response = await client.PostAsync($"Books/read/" + book.ID.ToString(), null);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var bookResult = await response.BodyAs<Book>();
            bookResult.IsReaded.Should().BeTrue();
        }
    }
}
