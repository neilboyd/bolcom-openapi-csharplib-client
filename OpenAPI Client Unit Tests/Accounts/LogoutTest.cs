using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class LogoutTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestLogout()
        {
            Login login = client.Login("M3F7zteABWh8tpGkZyitU003zUtohfZ6kLV5ZohuNFlqDS6LntSL1z6Me3yslsJX9hQGeh5VJor1P8hs9swT8Q1RhqGMRuxOBxYOGZp6YTFRi0X5BADsUDdUWX3YknbV3JgDIY30dwZNNHGa4em8YnPsl9j9LvESiQoC7RQhHoV94DfmMX31AIeMsliYqZVqN2e2wRcdekUvQJRGOltgEMh8GlL4IfG3c8KglOGCJZqUwYnfRzeEOjcKrgH4Los9", null);
            client.Logout(login.SessionId);
        }
    }
}
