using Bol.OpenAPI.Client;
using NUnit.Framework;
using Refit;
using System.Threading.Tasks;

namespace OpenAPI_Client_Standard_Unit_Tests.Utils
{
    [TestFixture]
    public class PingTest
    {
        private IOpenApiClient _client;

        [SetUp]
        public void Setup()
        {
            _client = RestService.For<IOpenApiClient>("https://api.bol.com");
        }

        [Test]
        public async Task TestPing()
        {
            var ping = await _client.Ping(Constants.API_KEY);

            Assert.That(ping, Is.Not.Null);
            Assert.That(ping.Message, Is.EqualTo("Hello world!"));
        }
    }
}
