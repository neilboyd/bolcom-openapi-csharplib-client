using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductOffersTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetProductOffers()
        {
            ProductOffersRequest productOffersRequest = new ProductOffersRequest();
            productOffersRequest.Id = "1004004012288125";
            productOffersRequest.Offers = new EnumTypes.OfferType[] { 
                    EnumTypes.OfferType.ALL
            };

            ProductOffers productOffers = client.GetProductOffers(productOffersRequest);
            Assert.IsNotNull(productOffers.OfferData);
            Assert.IsNotNull(productOffers.OfferData.Offers);
            Assert.IsTrue(productOffers.OfferData.Offers.Count > 0);
        }
    }
}
