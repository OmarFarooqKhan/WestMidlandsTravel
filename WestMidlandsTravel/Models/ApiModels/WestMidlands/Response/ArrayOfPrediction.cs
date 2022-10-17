using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response;

public class ArrayOfPrediction
{
    [JsonProperty("Prediction")]
    public List<string> Prediction { get; set; }
}