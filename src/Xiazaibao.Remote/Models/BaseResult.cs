using Newtonsoft.Json;

namespace Xiazaibao.Remote.Models
{
    public abstract class BaseResult
    {
        [JsonProperty(PropertyName = "msg")]
        public string Message { get; set; }

        public int Rtn { get; set; }
    }
}