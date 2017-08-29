using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiazaibao.Remote.Models
{
  public abstract class BaseResult
  {
    public StatusCode Code { get; set; }

    public string Message { get; set; }
  }
}
