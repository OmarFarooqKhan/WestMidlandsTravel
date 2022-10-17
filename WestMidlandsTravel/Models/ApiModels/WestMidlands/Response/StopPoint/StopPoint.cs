using Newtonsoft.Json;

namespace WestMidlandsTravel.Models.ApiModels.WestMidlands.Response.StopPoint;

public class StopPoint
{
    [JsonProperty("Lat")]
    public double Lat { get; set; }

    [JsonProperty("Lon")]
    public double Lon { get; set; }

    [JsonProperty("Indicator")]
    public string Indicator { get; set; }

    [JsonProperty("StopLetter")]
    public string StopLetter { get; set; }

    [JsonProperty("CommonName")]
    public string CommonName { get; set; }

    [JsonProperty("Locality")]
    public string Locality { get; set; }

    [JsonProperty("Id")]
    public string Id { get; set; }

    [JsonProperty("PlaceType")]
    public string PlaceType { get; set; }

    [JsonProperty("HubNaptanCode")]
    public string HubNaptanCode { get; set; }

    [JsonProperty("Lines")]
    public Lines Lines { get; set; }

    [JsonProperty("Modes")]
    public Modes Modes { get; set; }

    [JsonProperty("NaptanId")]
    public string NaptanId { get; set; }

    [JsonProperty("StationNaptan")]
    public string StationNaptan { get; set; }

    [JsonProperty("StopType")]
    public string StopType { get; set; }
}