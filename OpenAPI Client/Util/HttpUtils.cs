using System;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace Bol.OpenAPI.Util
{
    class HttpUtils
    {
        public static string ToQueryString(NameValueCollection nvc)
        {
            if (nvc != null && nvc.Count > 0)
            {
                // Does not support multi-value parameters, but for now we can accept that
                return "?" + string.Join("&", Array.ConvertAll(nvc.AllKeys, key => string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(nvc[key]))));
            }
            else
            {
                return "";
            }
        }

        public static void AddSessionheader(HttpWebRequest request, string sessionId)
        {
            if (sessionId != null)
            {
                request.Headers.Add("X-OpenAPI-Session-ID", sessionId);
            }            
        }
    }
}
