using Bol.OpenAPI.Request.Catalog;
using Refit;
using System.Threading.Tasks;

namespace Bol.OpenAPI.Client
{
    [Headers("User-Agent: bol.com API/4.0, refit#_,,^..^,,_")]
    public interface IOpenApiClient
    {
        void AddItemToBasket(string sessionId, string offerId, int quantity, string ipAddress);
        void AddItemToWishList(string sessionId, string productId);

        [Get("/catalog/v4/lists/?apikey={apikey}")]
        Task<ListResults> Browse(ListResultsRequest listResultsRequest, string apikey);

        void ChangeItemQuantityInBasket(string sessionId, string basketItemId, int quantity);
        Basket GetBasket(string sessionId);

        [Get("/catalog/v4/offers/{request.Id}/?apikey={apikey}")]
        Task<ProductOffers> GetProductOffers(ProductOffersRequest request, string apikey);

        ProductRecommendations GetProductRecommendations(ProductRecommendationsRequest productRecommendationsRequest);

        [Get("/catalog/v4/products/{request.Ids}/?apikey={apikey}")]
        Task<ProductList> GetProducts(ProductsRequest request, string apikey);

        RelatedProducts GetRelatedProducts(RelatedProductsRequest relatedProductsRequest);
        RequestAuthToken GetRequestAuthToken(string successUrl, string errorUrl);
        SellerList GetSellerList(SellerListRequest sellerListRequest);
        Session GetSession();
        WishList GetWishList(string sessionId);
        Login Login(string privateToken, string sessionId);
        void Logout(string sessionId);

        [Get("/utils/v4/ping/?apikey={apikey}")]
        Task<Pong> Ping(string apikey);

        void RemoveItemFromBasket(string sessionId, string basketItemId);
        void RemoveItemFromWishList(string sessionId, string wishListItemId);

        [Get("/catalog/v4/search/?apikey={apikey}")]
        Task<SearchResults> Search(SearchResultsRequest searchResultsRequest, string apikey);
    }
}