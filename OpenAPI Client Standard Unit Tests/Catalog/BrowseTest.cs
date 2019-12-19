using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using NUnit.Framework;
using Refit;
using System.Threading.Tasks;

namespace OpenAPI_Client_Standard_Unit_Tests.Catalog
{
    [TestFixture]
    public class BrowseTest
    {
        private IOpenApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = RestService.For<IOpenApiClient>("https://api.bol.com");
        }

        [Test]
        public async Task TestBrowse()
        {
            var request = new ListResultsRequest();
            var results = await _client.Browse(request, Constants.API_KEY);

            Assert.That(results, Is.Not.Null);
            Assert.That(results.Products, Is.Not.Empty);
        }
    }
}
