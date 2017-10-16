using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class BasketTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetBasket()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            Basket basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(0, basket.BasketItems.Count);
        }

        [TestMethod]
        public void TestAddItemToBasket()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            Basket basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(0, basket.BasketItems.Count);

            client.AddItemToBasket(session.SessionId, "1004004012288125", 1, "192.168.0.1");

            basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(1, basket.BasketItems.Count);
        }

        [TestMethod]
        public void TestChangeItemQuantityInBasket()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            Basket basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(0, basket.BasketItems.Count);

            client.AddItemToBasket(session.SessionId, "1004004012288125", 1, "192.168.0.1");

            basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(1, basket.BasketItems.Count);
            Assert.AreEqual(1, basket.BasketItems[0].Quantity);

            client.ChangeItemQuantityInBasket(session.SessionId, basket.BasketItems[0].Id, 2);

            basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(1, basket.BasketItems.Count);
            Assert.AreEqual(2, basket.BasketItems[0].Quantity);
        }

        [TestMethod]
        public void TestRemoveItemFromBasket()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            Basket basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(0, basket.BasketItems.Count);

            client.AddItemToBasket(session.SessionId, "1004004012288125", 1, "192.168.0.1");

            basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(1, basket.BasketItems.Count);

            client.RemoveItemFromBasket(session.SessionId, basket.BasketItems[0].Id);

            basket = client.GetBasket(session.SessionId);
            Assert.AreEqual(0, basket.BasketItems.Count);
        }
    }
}
