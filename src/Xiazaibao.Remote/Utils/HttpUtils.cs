using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xiazaibao.Remote.Models;

namespace Xiazaibao.Remote.Utils
{
  public class HttpUtils
  {
    protected HttpClient Client;

    public HttpUtils()
    {
      Client = new HttpClient();
    }

    public HttpUtils(HttpMessageHandler handler)
    {
      Client = new HttpClient(handler);
    }

    T Get<T>(string url, NameValueCollection param) where T : BaseResult
    {
      return default(T);
    }

    T Post<T>(string url, string filePath)
    {
      return Post<T>(url, null, filePath);
    }

    T Post<T>(string url, NameValueCollection param, string filePath)
    {
      return default(T);
    }
  }
}
