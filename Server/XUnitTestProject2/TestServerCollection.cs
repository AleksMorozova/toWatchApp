using MyToDoApp;
using Xunit;

namespace TestProject
{
    [CollectionDefinition("Test server", DisableParallelization = true)]
    public class TestServerCollection : ICollectionFixture<CustomWebApplicationFactory<Startup>>
    {
    }
}
