using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xiazaibao.Remote.Models;

namespace Xiazaibao.Remote.Utils
{
    public class HttpUtils : IDisposable
    {
        protected HttpClient Client;

        public HttpUtils(Uri domain)
        {
            Client = new HttpClient() { BaseAddress = domain };
        }

        public HttpUtils(HttpMessageHandler handler, Uri domain)
        {
            Client = new HttpClient(handler) { BaseAddress = domain };
        }

        public T Get<T>(string url)
        {
            Task<string> result = Client.GetStringAsync(url);
            string content = result?.Result;
            return JsonConvert.DeserializeObject<T>(content ?? "{}");
        }
        public T Post<T>(string url, string filePath)
        {
            return Post<T>(url, null, filePath);
        }

        public T Post<T>(string url, NameValueCollection param, string filePath)
        {
            return default(T);
        }

        public Cookie GetCookie(string url, string name)
        {
            var uri = new Uri(url);
            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler { CookieContainer = cookies };
            HttpClient client = new HttpClient(handler);
            client.GetAsync(uri).Wait();
            IEnumerable<Cookie> responseCookies = cookies.GetCookies(uri).Cast<Cookie>();
            return responseCookies.FirstOrDefault(x => x.Name == name);
        }

        public void Dispose()
        {
            Client?.Dispose();
        }
    }

}
