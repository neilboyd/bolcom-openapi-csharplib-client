using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class BrowseTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestBrowse()
        {
            ListResultsRequest listResultsRequest = new ListResultsRequest();
            listResultsRequest.Type = EnumTypes.ListType.DEFAULT;
            listResultsRequest.CategoryId = "3135";
            listResultsRequest.IncludeAttributes = true;
            listResultsRequest.Offset = 10;
            listResultsRequest.Limit = 10;
            listResultsRequest.DataOutputs = new EnumTypes.DataOutputType[] { 
                    EnumTypes.DataOutputType.PRODUCTS,
                    EnumTypes.DataOutputType.CATEGORIES,
                    EnumTypes.DataOutputType.REFINEMENTS
                };
            listResultsRequest.Offers = new EnumTypes.OfferType[] { 
                    EnumTypes.OfferType.ALL
                };

            ListResults listResults = client.Browse(listResultsRequest);
            Assert.IsTrue(listResults.TotalResultSize > 0);
            Assert.IsNotNull(listResults.Categories);
            Assert.IsTrue(listResults.Categories.Count > 0);
            Assert.IsNotNull(listResults.Products);
            Assert.IsTrue(listResults.Products.Count > 0);
            Assert.IsNotNull(listResults.RefinementGroups);
            Assert.IsTrue(listResults.RefinementGroups.Count > 0);     
        }
    }
}
