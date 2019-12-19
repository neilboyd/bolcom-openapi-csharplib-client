using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using NUnit.Framework;
using Refit;
using System.Threading.Tasks;

namespace OpenAPI_Client_Standard_Unit_Tests.Catalog
{
    [TestFixture]
    public class CatalogTest
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

        [Test]
        public async Task TestGetProducts()
        {
            var request = new ProductOffersRequest
            {
                Id = "1004004012288125"
            };
            var results = await _client.GetProductOffers(request, Constants.API_KEY);

            Assert.That(results, Is.Not.Null);
            Assert.That(results.OfferData.Offers, Is.Not.Empty);
        }

        [Test]
        public async Task TestGetProductOffers()
        {
            var request = new ProductsRequest
            {
                Ids = new string[] { "1004004012288125" }
            };
            var results = await _client.GetProducts(request, Constants.API_KEY);

            Assert.That(results, Is.Not.Null);
            Assert.That(results.Products, Is.Not.Empty);
        }

        [Test]
        public async Task TestSearch()
        {
            SearchResultsRequest request = new SearchResultsRequest();
            request.Query = "halo";
            request.IncludeAttributes = true;
            request.Offset = 10;
            request.Limit = 10;
            request.DataOutputs = new EnumTypes.DataOutputType[] {
                EnumTypes.DataOutputType.PRODUCTS,
                EnumTypes.DataOutputType.CATEGORIES,
                EnumTypes.DataOutputType.REFINEMENTS
            };
            request.Offers = new EnumTypes.OfferType[] {
                EnumTypes.OfferType.ALL
            };

            var results = await _client.Search(request, Constants.API_KEY);

            Assert.That(results, Is.Not.Null);
            Assert.That(results.Products, Is.Not.Empty);
        }
    }
}
