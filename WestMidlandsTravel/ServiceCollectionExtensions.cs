using System.Reflection;
using Microsoft.OpenApi.Models;
using WestMidlandsTravel.Integrations.GTFSRealTime.Http;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.Http;
using WestMidlandsTravel.Integrations.TransportForWestMidlands.Services;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "WestMidlandsTravel.Startup", Version = "v1" });
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        services.AddSingleton<IRouteService, RouteService>();
        services.AddSingleton<IStopService, StopService>();
    }

    public static void RegisterConfigurations(this WebApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        builder.Configuration.AddEnvironmentVariables();

        builder.Services.Configure<WestMidlandsTransportOptions>(builder.Configuration.GetSection("TransportIntegrations:WestMidlandsTransport"));
        builder.Services.Configure<GtfsRealtimeOptions>(builder.Configuration.GetSection("TransportIntegrations:GtfsRealtime"));
    }

    public static void RegisterHttpClients(this IServiceCollection service)
    {
        service.AddHttpClient<IWestMidlandsRouteHttpClient, WestMidlandsRouteLineHttpClient>();
        service.AddHttpClient<IWestMidlandsStopHttpClient, WestMidlandsStopHttpClient>();
        service.AddHttpClient<IGtfsRealTimeHttpClient, GtfsRealTimeHttpClient>();
    }
}