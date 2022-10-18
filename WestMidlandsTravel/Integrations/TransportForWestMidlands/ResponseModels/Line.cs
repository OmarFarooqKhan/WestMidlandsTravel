using Newtonsoft.Json;

namespace WestMidlandsTravel.Integrations.TransportForWestMidlands.ResponseModels;

public class Line
{
   [JsonProperty("Id")]
   public string Id { get; set; }

   [JsonProperty("Name")]
   public string Name { get; set; }

   [JsonProperty("ModeName")]
   public string ModeName { get; set; }

   [JsonProperty("Uri")]
   public string Uri { get; set; }

   [JsonProperty("Operators")]
   public Operators Operators { get; set; }

   [JsonProperty("RouteSections")]
   public RouteSections RouteSections { get; set; }
}