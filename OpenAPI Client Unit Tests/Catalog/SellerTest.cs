using Bol.OpenAPI.Client;
using Bol.OpenAPI.Request.Catalog;
using Bol.OpenAPI.Request.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests.Catalog
{
    [TestClass]
    public class SellerTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetSellerList()
        {
            SellerListRequest sellerListRequest = new SellerListRequest();
            sellerListRequest.Id = "656476";
            sellerListRequest.IncludeAttributes = true;
            sellerListRequest.Offset = 0;
            sellerListRequest.Limit = 10;
            sellerListRequest.Sort = EnumTypes.SortingMethod.DATE_DESC;

            SellerList sellerList = client.GetSellerList(sellerListRequest);
            Assert.IsNotNull(sellerList.Products);
            Assert.IsTrue(sellerList.Products.Count > 0);
        }
    }
}
