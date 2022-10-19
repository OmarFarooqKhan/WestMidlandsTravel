using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class WestMidlandsPredictionsResponse
{
    [JsonProperty("Predictions")]
    public Predictions Data { get; set; }
}