using System.Text.Json;
using System.Text.Json.Serialization;
using FluentValidation;
using IT.Mechanic.App.Services.Profiles;
using IT.Mechanic.App.Services.Settings;
using IT.Mechanic.App.Validators;
using IT.Mechanic.App.ViewModels;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;

namespace IT.Mechanic.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                })
                .RegisterServices()
                .RegisterValidators();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services.AddSingleton<JsonSerializerOptions>(
                new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
                }
            );
            builder.Services.AddSingleton<ISettingsService, SettingsService>();
            builder.Services.AddSingleton<ICredentialService, CredentialService>();
            builder.Services.AddSingleton<IProfileService, ProfileService>();
            builder.Services.AddSingleton<IProfileFactory, ProfileFactory>();

            return builder;
        }

        public static MauiAppBuilder RegisterValidators(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<DNSValidator>();
            builder.Services.AddSingleton<ServerValidator>();
            builder.Services.AddSingleton<ProductSelectionValidator>();
            builder.Services.AddSingleton<IValidator<SiteConfigViewModel>, SiteConfigValidator>();

            return builder;
        }
    }
}
