using System.Collections.Specialized;
using System.Net;

namespace Bol.OpenAPI.Util
{
    class AccountsRequestBuilder
    {
        public static HttpWebRequest ConstructSessionRequest(string apiKey)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);
            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/sessions/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";

            return request;
        }

        public static HttpWebRequest ConstructAuthTokenRequest(string apiKey, string successUrl, string errorUrl)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);

            if (successUrl != null)
            {
                queryParams.Add("successurl", successUrl);
            }
            if (errorUrl != null)
            {
                queryParams.Add("errorUrl", errorUrl);
            }

            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/authtokens/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";

            return request;
        }

        public static HttpWebRequest ConstructLoginRequest(string apiKey, string privateToken, string sessionId)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);

            if (privateToken != null)
            {
                queryParams.Add("privatetoken", privateToken);
            }

            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/login/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionheader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructLogoutRequest(string apiKey, string sessionId)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);

            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/logout/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionheader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructWishListRequest(string apiKey, string sessionId)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);

            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/wishlists/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";
            HttpUtils.AddSessionheader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructWishListAddItemRequest(string apiKey, string sessionId, string productId)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);

            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/wishlists/" + productId + "/" + queryString);
            request.Method = "POST";
            request.Accept = "application/json";
            HttpUtils.AddSessionheader(request, sessionId);

            return request;
        }

        public static HttpWebRequest ConstructWishListRemoveItemRequest(string apiKey, string sessionId, string wishListItemId)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);

            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/accounts/v4/wishlists/" + wishListItemId + "/" + queryString);
            request.Method = "DELETE";
            request.Accept = "application/json";
            HttpUtils.AddSessionheader(request, sessionId);

            return request;
        }
    }
}
