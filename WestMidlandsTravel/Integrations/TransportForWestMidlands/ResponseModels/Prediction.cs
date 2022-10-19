using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class Prediction
{
    [JsonProperty("DestinationName")]
    public string DestinationName { get; set; }

    [JsonProperty("DestinationNaptanId")]
    public string DestinationNaptanId { get; set; }

    [JsonProperty("Direction")]
    public string Direction { get; set; }

    [JsonProperty("ExpectedArrival")]
    public DateTime ExpectedArrival { get; set; }

    [JsonProperty("ScheduledArrival")]
    public DateTime ScheduledArrival { get; set; }

    [JsonProperty("Id")]
    public string Id { get; set; }

    [JsonProperty("LineId")]
    public string LineId { get; set; }

    [JsonProperty("LineName")]
    public string LineName { get; set; }

    [JsonProperty("ModeName")]
    public string ModeName { get; set; }

    [JsonProperty("StopSequence")]
    public string StopSequence { get; set; }

    [JsonProperty("NaptanId")]
    public string NaptanId { get; set; }

    [JsonProperty("PlatformName")]
    public string PlatformName { get; set; }

    [JsonProperty("StationName")]
    public string StationName { get; set; }

    [JsonProperty("TimeToLive")]
    public DateTime TimeToLive { get; set; }

    [JsonProperty("TimeToStation")]
    public string TimeToStation { get; set; }

    [JsonProperty("Timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonProperty("Towards")]
    public string Towards { get; set; }

    [JsonProperty("VehicleId")]
    public string VehicleId { get; set; }

    [JsonProperty("Operator")]
    public Operator Operator { get; set; }
}