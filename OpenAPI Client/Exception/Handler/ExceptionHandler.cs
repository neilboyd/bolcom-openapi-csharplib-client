using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;

namespace Bol.OpenAPI.Exception.Handler
{
    class ExceptionHandler
    {
        public static BasicApiException HandleBasicApiException(HttpWebResponse response)
        {
            string status = response.StatusCode.ToString();
            string message = response.StatusDescription;
            try
            {
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    message = reader.ReadToEnd();
                    Error error = JsonConvert.DeserializeObject<Error>(message);
                    status = error.Code;
                    message = error.Message;
                }
            }
            catch
            {
            }
            return new BasicApiException(response.StatusCode, status, message);
        }
    }
}
