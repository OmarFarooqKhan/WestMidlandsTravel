using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

public class ArrayOfStopPoint
{
    [JsonProperty("StopPoint")]
    public List<StopPoint> StopPoint { get; set; }
}