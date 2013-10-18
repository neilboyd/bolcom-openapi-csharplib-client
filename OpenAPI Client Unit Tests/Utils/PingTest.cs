using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class PingTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestPing()
        {
            Pong pong = client.Ping();
            Assert.IsNotNull(pong.Message);
        }
    }
}
