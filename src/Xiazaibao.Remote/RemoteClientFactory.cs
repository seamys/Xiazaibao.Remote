using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiazaibao.Remote
{
  public class RemoteClientFactory
  {
    public IRemoteClient GetClient()
    {
      return GetClient(null);
    }

    public IRemoteClient GetClient(Version version)
    {
      if (version == null)
        return new RemoteClient();
      return null;
    }
  }
}
