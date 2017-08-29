using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiazaibao.Remote.Models;

namespace Xiazaibao.Remote
{
    public interface IRemoteClient
    {
        PeerListResult GetListPeer(int type);
    }
}
