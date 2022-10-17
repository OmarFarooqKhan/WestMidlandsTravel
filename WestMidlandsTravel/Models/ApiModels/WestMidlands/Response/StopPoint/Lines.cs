using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

public class Lines
{
    [JsonProperty("Identifier")]
    public List<Identifier> Identifier { get; set; }
}