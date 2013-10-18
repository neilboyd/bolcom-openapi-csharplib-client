using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class RequestAuthTokenTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetRequestAuthToken()
        {
            RequestAuthToken requestAuthToken = client.GetRequestAuthToken("https://m.bol.com/nl/", "https://m.bol.com/nl/error/");
            Assert.IsNotNull(requestAuthToken.Code);
            Assert.IsNotNull(requestAuthToken.PrivateToken);
            Assert.IsNotNull(requestAuthToken.Url);
        }
    }
}
