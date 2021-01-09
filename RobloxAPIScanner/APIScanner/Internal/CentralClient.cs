using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace APIScanner.Internal
{
    public static class CentralClient
    {
        static CentralClient()
        {
            SetHeaders(client);
        }
        public static HttpClient Client { get { return client; } }
        public static HttpClientHandler Handler { get { return Handler; } }

        private static HttpClientHandler handler = new HttpClientHandler()
        {
            AutomaticDecompression = (DecompressionMethods)(-1)
        };
        private static HttpClient client = new HttpClient(handler);


        private static void SetHeaders(HttpClient Client)
        {
            Client.DefaultRequestHeaders.Add("Accept", "*/*");

            Client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip");
            Client.DefaultRequestHeaders.Add("Accept-Encoding", "deflate");
            Client.DefaultRequestHeaders.Add("Accept-Encoding", "br");

            Client.DefaultRequestHeaders.Add("Accept-Language", "nl");
            Client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36 Edg/87.0.664.57");
            Client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

            //Client.DefaultRequestHeaders.Add("Host", "steamcommunity.com");
            //Client.DefaultRequestHeaders.Add("Origin", "https://steamcommunity.com");
            //Client.DefaultRequestHeaders.Add("Referer", "https://steamcommunity.com/login/home/?goto=");

            //Client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
            //Client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
            //Client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
        }
    }
}
