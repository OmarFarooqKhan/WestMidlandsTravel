using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

public class Identifier
{
    [JsonProperty("Id")]
    public string Id { get; set; }

    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("Type")]
    public string Type { get; set; }

    [JsonProperty("Uri")]
    public string Uri { get; set; }

    [JsonProperty("Operators")]
    public Operators Operators { get; set; }
}
