using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

public class ArrayOfStopPoint
{
    [JsonProperty("StopPoint")]
    public List<StopPoint> StopPoint { get; set; }
}