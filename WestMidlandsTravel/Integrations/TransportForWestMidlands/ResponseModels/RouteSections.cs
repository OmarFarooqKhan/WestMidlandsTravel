using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class RouteSections
{
    [JsonProperty("MatchedRoute")]
    public IEnumerable<MatchedRoute> MatchedRoute { get; set; }
    
}