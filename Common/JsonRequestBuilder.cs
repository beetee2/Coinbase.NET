using System;
using System.IO;
using System.Net;

namespace Common
{
    public static class JsonRequestBuilder
    {
        public static string JsonRequest(string url, string method)
        {
            string returnData = String.Empty;

            var webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            if (webRequest != null)
            {
                webRequest.Accept = "*/*";
                webRequest.UserAgent = ".NET";
                webRequest.Method = method;
                webRequest.ContentType = "application/json";
                webRequest.Host = "coinbase.com";

                string nonce = Convert.ToInt64(DateTime.Now.Ticks).ToString();
                string message = nonce + url;
                string signature = Encoding.HashEncode(Encoding.HashHMAC(Encoding.StringEncode(APIKeys.API_SECRET), Encoding.StringEncode(message)));

                var whc = new WebHeaderCollection();
                whc.Add("ACCESS_KEY: " + APIKeys.API_KEY);
                whc.Add("ACCESS_SIGNATURE: " + signature);
                whc.Add("ACCESS_NONCE: " + nonce);
                webRequest.Headers = whc;

                using (WebResponse response = webRequest.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        returnData = reader.ReadToEnd();
                    }
                }
            }

            return returnData;
        }
    }
}
