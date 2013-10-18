using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class LoginTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestLogin()
        {
            // Insert proper private token that has user permission.

            //Login login = client.Login("", null);
            //Assert.IsNotNull(login.Name);
            //Assert.IsNotNull(login.SessionId);
        }
    }
}
