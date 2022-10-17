using Microsoft.OpenApi.Models;
using WestMidlandsTravel.BusinessLayer;
using WestMidlandsTravel.Http;
using WestMidlandsTravel.Startup.Configuration;

namespace WestMidlandsTravel;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "WestMidlandsTravel.Startup", Version = "v1" });
        });

        services.AddSingleton<IRouteService, RouteService>();
        services.AddSingleton<IStopService, StopService>();
    }

    public static void RegisterConfigurations(this WebApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        builder.Configuration.AddEnvironmentVariables();

        builder.Services.Configure<WestMidlandsTransportOptions>(builder.Configuration.GetSection("WestMidlandsTransport"));
    }

    public static void RegisterHttpClients(this IServiceCollection service)
    {
        service.AddHttpClient<IWestMidlandsRouteHttpClient, WestMidlandsRouteLineHttpClient>();
        service.AddHttpClient<IWestMidlandsStopHttpClient, WestMidlandsStopHttpClient>();
    }
}