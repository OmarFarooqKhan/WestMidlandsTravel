using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

public class Operators
{
    [JsonProperty("Operator")]
    public IEnumerable<Operator> Operator { get; set; }
}