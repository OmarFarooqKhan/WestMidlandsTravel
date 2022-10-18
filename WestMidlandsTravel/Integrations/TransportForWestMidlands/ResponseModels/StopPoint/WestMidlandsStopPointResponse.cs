using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

public class WestMidlandsStopPointResponse
{
    [JsonProperty("ArrayOfStopPoint")]
    public ArrayOfStopPoint ArrayOfStopPoint { get; set; }
}