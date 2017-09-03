using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using Newtonsoft.Json;
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
      this.Init(sessionId, userid, "http://homecloud.remote.xiazaibao.xunlei.com");
    }

    public RemoteClient(string sessionId, string userId, string domain)
    {
      this.Init(sessionId, userId, domain);
    }

    protected void Init(string sessionId, string userid, string url)
    {
      this.Domain = new Uri(url);
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
        /// <summary>
        /// 返回当前正在下载的任务列表
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="type"></param>
        /// <param name="number"></param>
        /// <returns></returns>

        public SettingsResult GetConfig(string pid)
        {
            return HttpUtils.Get<SettingsResult>("settings", pid);
        }

        public SettingsResult SetConfig(string pid, SettingsResult settings)
        {
            throw new NotImplementedException();
        }

        public RenameResult Rename(string pid, string boxName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取存储设备剩余空间
        /// </summary>
        /// <param name="pid">设备ID</param>
        /// <returns>返回设每个存储设备的剩余空间</returns>
        public BoxSpaceResult BoxSpace(string pid)
        {
            return HttpUtils.Get<BoxSpaceResult>("boxSpace", pid);
        }

        public VerifyAccessCodeResult VerifyAccessCode(string pid, string password)
        {
            throw new NotImplementedException();
        }
        public TaskListResult List(string pid, int type, int number)
        {
            return HttpUtils.Get<TaskListResult>($"/list?pid={pid}&type={type}&number={number}&pos=0&v=2&ct=0");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="magnet"></param>
        /// <returns></returns>
        public UrlResolveResult UrlResolveResult(string pid, string magnet)
        {
            var url = HttpUtils.GetSimpleUrl("urlResolve", pid);
            var obj = new { url = magnet };
            return HttpUtils.Post<UrlResolveResult>(url, new NameValueCollection() { { "json", JsonConvert.SerializeObject(obj) } });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="stream"></param>
        /// <returns></returns>
        public BtCheckResult BtCheck(string pid, Stream stream)
        {
            return HttpUtils.Get<BtCheckResult>("settings", pid);
        }
    }
}