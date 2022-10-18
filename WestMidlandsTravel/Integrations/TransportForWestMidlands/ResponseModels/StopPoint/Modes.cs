using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

public class Modes
{
    [JsonProperty("Mode")]
    public string Mode { get; set; }
}