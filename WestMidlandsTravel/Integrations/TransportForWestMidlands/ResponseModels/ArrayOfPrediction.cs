using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class ArrayOfPrediction
{
    [JsonProperty("Prediction")]
    public List<string> Prediction { get; set; }
}