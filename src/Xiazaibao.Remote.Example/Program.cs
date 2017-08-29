using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Xiazaibao.Remote.Example
{
    public class Program
    {
        static void Main(string[] arg)
        {
            string sessionId = "###";
            string userid = "#####";
            var client = new RemoteClient(sessionId, userid);
            var list = client.GetListPeer(0);
            var tasks = client.GetTaskList("#####", 0, 50);
        }
    }
}
