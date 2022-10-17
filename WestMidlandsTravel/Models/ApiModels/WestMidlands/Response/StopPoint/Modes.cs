using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

public class Modes
{
    [JsonProperty("Mode")]
    public string Mode { get; set; }
}