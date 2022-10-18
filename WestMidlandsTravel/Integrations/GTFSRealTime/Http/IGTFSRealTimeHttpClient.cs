using TransitRealtime;

namespace WestMidlandsTravel.Integrations.GTFSRealTime.Http;

public interface IGtfsRealTimeHttpClient
{ 
    Task<IEnumerable<FeedEntity>> GetAsync(string url);
}