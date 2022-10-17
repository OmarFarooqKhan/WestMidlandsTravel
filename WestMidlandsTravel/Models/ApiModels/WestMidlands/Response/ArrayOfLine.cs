using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

public class ArrayOfLine
{
    [JsonProperty("Line")]
    public IEnumerable<Line> Line { get; set; }
}