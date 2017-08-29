using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xiazaibao.Remote.Models;

namespace Xiazaibao.Remote
{
  public interface IRemoteClient
  {
    AccessKeyResult GetAccessKey(string username, string password);
  }
}
