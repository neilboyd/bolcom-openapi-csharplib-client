using Bol.OpenAPI.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAPI_Client_Unit_Tests
{
    [TestClass]
    public class WishListTest
    {
        private OpenApiClient client = new OpenApiClient(Constants.API_KEY);

        [TestMethod]
        public void TestGetWishList()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            WishList wishList = client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);
        }

        [TestMethod]
        public void TestAddItemToWishList()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            WishList wishList = client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

            client.AddItemToWishList(session.SessionId, "1004004012288125");

            wishList = client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 1);
        }

        [TestMethod]
        public void TestRemoveItemFromWishList()
        {
            Session session = client.GetSession();
            Assert.IsNotNull(session.SessionId);

            WishList wishList = client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

            client.AddItemToWishList(session.SessionId, "1004004012288125");

            wishList = client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 1);

            client.RemoveItemFromWishList(session.SessionId, wishList.WishListItems[0].Id);

            wishList = client.GetWishList(session.SessionId);
            Assert.IsTrue(wishList.WishListItems.Count == 0);

        }
    }
}
