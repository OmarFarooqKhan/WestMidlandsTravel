using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class Predictions
{
    [JsonProperty("Prediction")]
    public IEnumerable<Prediction> ListOfPredictions { get; init; }
}