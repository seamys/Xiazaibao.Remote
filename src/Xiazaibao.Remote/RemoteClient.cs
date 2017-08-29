using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using Xiazaibao.Remote.Models;
using Xiazaibao.Remote.Utils;

namespace Xiazaibao.Remote
{
    public class RemoteClient : IRemoteClient
    {
        protected HttpUtils HttpUtils;
        protected Uri Domain;
        public RemoteClient(string sessionId, string userid)
        {
            this.Domain = new Uri("http://homecloud.remote.xiazaibao.xunlei.com");
            HttpClientHandler hander = new HttpClientHandler
            {
                CookieContainer = new CookieContainer()
            };
            hander.CookieContainer.Add(this.Domain, new Cookie("sessionid", sessionId));
            hander.CookieContainer.Add(this.Domain, new Cookie("userid", userid));
            HttpUtils = new HttpUtils(hander, this.Domain);
        }
        public PeerListResult GetListPeer(int type)
        {
            return HttpUtils.Get<PeerListResult>($"/listPeer?type={type}");
        }

        public TaskListResult GetTaskList(string pid, int type, int number)
        {
            return HttpUtils.Get<TaskListResult>($"/list?pid={pid}&type={type}&number={number}&pos=0&v=2&ct=0");
        }
    }
}