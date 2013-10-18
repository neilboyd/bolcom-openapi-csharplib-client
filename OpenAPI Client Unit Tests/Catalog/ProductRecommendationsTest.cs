using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductRecommendationsTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetProductRecommendation()
        {
            ProductRecommendationsRequest productRecommendationsRequest = new ProductRecommendationsRequest();
            productRecommendationsRequest.Id = "1004004012288125";
            productRecommendationsRequest.IncludeAttributes = true;
            productRecommendationsRequest.Offers = new EnumTypes.OfferType[] { 
                    EnumTypes.OfferType.ALL
            };
            productRecommendationsRequest.Offset = 0;
            productRecommendationsRequest.Limit = 10;

            ProductRecommendations productRecommendations = client.GetProductRecommendations(productRecommendationsRequest);
            Assert.IsNotNull(productRecommendations.Products);
            Assert.IsTrue(productRecommendations.Products.Count > 0);
        }
    }
}
