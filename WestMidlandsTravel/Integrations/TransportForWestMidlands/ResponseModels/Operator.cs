using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class Operator
{
    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("Code")]
    public string Code { get; set; }

    [JsonProperty("Id")]
    public string Id { get; set; }
}