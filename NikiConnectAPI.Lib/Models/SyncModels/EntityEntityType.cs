using Newtonsoft.Json;

namespace NikiConnectAPI.Lib.Models.SyncModels
{
    public class EntityEntityType
    {
        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("entity_type_id")]
        public int EntityTypeId { get; set; }
    }
}
