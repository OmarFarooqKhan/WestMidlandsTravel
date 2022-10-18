using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels.StopPoint;

public class Lines
{
    [JsonProperty("Identifier")]
    public List<Identifier> Identifier { get; set; }
}