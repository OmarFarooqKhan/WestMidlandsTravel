using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

public class Operator
{
    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("Code")]
    public string Code { get; set; }

    [JsonProperty("Id")]
    public string Id { get; set; }
}