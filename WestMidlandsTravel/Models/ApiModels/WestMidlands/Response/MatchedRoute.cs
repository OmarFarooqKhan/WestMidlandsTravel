using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

public class MatchedRoute
{
    [JsonProperty("Originator")]
    public string Originator { get; set; }

    [JsonProperty("OriginationName")]
    public string OriginationName { get; set; }

    [JsonProperty("Destination")]
    public string Destination { get; set; }

    [JsonProperty("DestinationName")]
    public string DestinationName { get; set; }

    [JsonProperty("Direction")]
    public string Direction { get; set; }

    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("RouteCode")]
    public string RouteCode { get; set; }

    [JsonProperty("Operators")]
    public Operators Operators { get; set; }
    

}