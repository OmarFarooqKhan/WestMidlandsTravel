namespace WestMidlandsTravel.Startup.Configuration;

public class GtfsRealtimeOptions
{
    public string ApiKey { get; set ; }
    public string ApiSecret { get; set; }
    public string Url { get; set; }
    public int Timeout { get; set; }
}