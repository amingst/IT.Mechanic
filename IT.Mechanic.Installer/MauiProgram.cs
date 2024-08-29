using CommunityToolkit.Maui;
using IT.Mechanic.Installer.Models;
using IT.Mechanic.Installer.Services;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IT.Mechanic.Installer
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fa-regular-400.ttf", "FaRegular");
                    fonts.AddFont("fa-solid-900.ttf", "FaSolid");
                })
                .RegisterServices();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<JsonSerializerOptions>(new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                },
            });
            builder.Services.AddSingleton<MechanicSettings>();
            builder.Services.AddSingleton<SettingsService>();
            builder.Services.AddSingleton<ConfigService>();
            builder.Services.AddSingleton<ProfileService>();
            return builder;
        }
    }
}
