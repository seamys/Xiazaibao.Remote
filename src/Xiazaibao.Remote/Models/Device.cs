using Newtonsoft.Json;

namespace Xiazaibao.Remote.Models
{
    public class Device
    {
        public string AccessCode { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public int DeviceVersion { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        [JsonProperty(PropertyName = "path_list")]
        public string PathList { get; set; }
        public string Pid { get; set; }
        public int Status { get; set; }
        public int VodPort { get; set; }
    }
}