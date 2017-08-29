using System;
using System.Collections.Generic;

namespace Xiazaibao.Remote.Models
{
    public class PeerListResult
    {
        public List<Device> PeerList { get; set; }
        public int Rtn { get; set; }
    }
}