using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class Operators
{
    [JsonProperty("Operator")]
    public IEnumerable<Operator> Operator { get; set; }
}