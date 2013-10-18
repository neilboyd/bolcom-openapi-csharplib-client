using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class ProductsTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetProduct()
        {
            ProductsRequest productsRequest = new ProductsRequest();
            productsRequest.Ids = new string[] { "1004004012288125" };
            productsRequest.IncludeAttributes = true;
            productsRequest.Offers = new EnumTypes.OfferType[] { 
                    EnumTypes.OfferType.ALL
            };

            ProductList productList = client.GetProducts(productsRequest);
            Assert.IsNotNull(productList.Products);
            Assert.IsTrue(productList.Products.Count == 1);
        }

        [TestMethod]
        public void TestGetProducts()
        {
            ProductsRequest productsRequest = new ProductsRequest();
            productsRequest.Ids = new string[] { "1004004012288125", "1004004012257956" };
            productsRequest.IncludeAttributes = true;
            productsRequest.Offers = new EnumTypes.OfferType[] { 
                    EnumTypes.OfferType.ALL
            };

            ProductList productList = client.GetProducts(productsRequest);
            Assert.IsNotNull(productList.Products);
            Assert.IsTrue(productList.Products.Count == 2);
        }
    }
}
