using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

public class RouteSections
{
    [JsonProperty("MatchedRoute")]
    public IEnumerable<MatchedRoute> MatchedRoute { get; set; }
    
}