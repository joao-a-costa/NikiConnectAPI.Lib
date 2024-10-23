using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Interfaces
{
    public interface IBaseModel
    {
        [JsonProperty("id")]
        int Id { get; set; }
    }
}
