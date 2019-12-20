using Bol.OpenAPI.Request.Catalog;
using Refit;
using System.Threading.Tasks;

namespace Bol.OpenAPI.Client
{
    [Headers("User-Agent: bol.com API/4.0, refit#_,,^..^,,_")]
    public interface IOpenApiClient
    {
        [Get("/catalog/v4/lists/?apikey={apikey}")]
        Task<ListResults> Browse(ListResultsRequest listResultsRequest, string apikey);

        [Get("/catalog/v4/offers/{request.Id}/?apikey={apikey}")]
        Task<ProductOffers> GetProductOffers(ProductOffersRequest request, string apikey);

        [Get("/catalog/v4/products/{productIds}/?apikey={apikey}")]
        Task<ProductList> GetProducts(ProductsRequest request, string productIds, string apikey);

        [Get("/utils/v4/ping/?apikey={apikey}")]
        Task<Pong> Ping(string apikey);

        [Get("/catalog/v4/search/?apikey={apikey}")]
        Task<SearchResults> Search(string apikey,
            [AliasAs("q")] string query = null,
            [AliasAs("pids")] string[] productIds = null,
            [AliasAs("ids")] string[] refinementIds = null, // categoryId and refinementIds
            string listId = null,
            [AliasAs("searchfield")] string searchField = null,
            bool? includeAttributes = null,
            string[] dataOutput = null,
            string[] offers = null,
            string sort = null,
            long? offset = null,
            int? limit = null
            );

        #region methods that are extracted from the client but not yet implemented

        void AddItemToBasket(string sessionId, string offerId, int quantity, string ipAddress);
        void AddItemToWishList(string sessionId, string productId);
        void ChangeItemQuantityInBasket(string sessionId, string basketItemId, int quantity);
        Basket GetBasket(string sessionId);
        ProductRecommendations GetProductRecommendations(ProductRecommendationsRequest productRecommendationsRequest);
        RelatedProducts GetRelatedProducts(RelatedProductsRequest relatedProductsRequest);
        RequestAuthToken GetRequestAuthToken(string successUrl, string errorUrl);
        SellerList GetSellerList(SellerListRequest sellerListRequest);
        Session GetSession();
        WishList GetWishList(string sessionId);
        Login Login(string privateToken, string sessionId);
        void Logout(string sessionId);
        void RemoveItemFromBasket(string sessionId, string basketItemId);
        void RemoveItemFromWishList(string sessionId, string wishListItemId);

        #endregion
    }
}