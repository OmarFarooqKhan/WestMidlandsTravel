using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

public class WestMidlandsStopPointResponse
{
    [JsonProperty("ArrayOfStopPoint")]
    public ArrayOfStopPoint ArrayOfStopPoint { get; set; }
}