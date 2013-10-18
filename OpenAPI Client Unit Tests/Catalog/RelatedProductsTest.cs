using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class RelatedProductsTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetProductFamilies()
        {
            RelatedProductsRequest relatedProductsRequest = new RelatedProductsRequest();
            relatedProductsRequest.Id = "9200000009187246";
            relatedProductsRequest.DataSet = new EnumTypes.DataSetType[] { 
                    EnumTypes.DataSetType.PRODUCT_FAMILY
            };

            RelatedProducts relatedProducts = client.GetRelatedProducts(relatedProductsRequest);
            Assert.IsNotNull(relatedProducts.ProductFamilies);
            Assert.IsTrue(relatedProducts.ProductFamilies.Count > 0);
        }

        [TestMethod]
        public void TestGetAccessories()
        {
            RelatedProductsRequest relatedProductsRequest = new RelatedProductsRequest();
            relatedProductsRequest.Id = "9200000010642550";
            relatedProductsRequest.DataSet = new EnumTypes.DataSetType[] {     
                    EnumTypes.DataSetType.ACCESSORIES,
            };

            RelatedProducts relatedProducts = client.GetRelatedProducts(relatedProductsRequest);
           Assert.IsNotNull(relatedProducts.Accessories);
            Assert.IsTrue(relatedProducts.Accessories.Count > 0);
        }
    }
}
