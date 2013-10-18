using System.Collections.Specialized;
using System.Net;

namespace Bol.OpenAPI.Util
{
    class UtilsRequestBuilder
    {
        public static HttpWebRequest ConstructPingRequest(string apiKey)
        {
            NameValueCollection queryParams = new NameValueCollection();
            queryParams.Add("apikey", apiKey);
            string queryString = HttpUtils.ToQueryString(queryParams);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.URL_PREFIX + "/utils/v4/ping/" + queryString);
            request.Method = "GET";
            request.Accept = "application/json";

            return request;
        }       
    }
}
