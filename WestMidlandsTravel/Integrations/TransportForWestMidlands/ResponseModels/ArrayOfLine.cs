using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class ArrayOfLine
{
    [JsonProperty("Line")]
    public IEnumerable<Line> Line { get; set; }
}