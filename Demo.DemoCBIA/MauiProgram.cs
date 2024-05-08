using Demo.DemoCBIA.Pages;
using DevExpress.Maui;
using DevExpress.Maui.Core;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Demo.ApiClient.IoC;
using Syncfusion.Maui.Core.Hosting;

namespace Demo.DemoCBIA
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            //ThemeManager.ApplyThemeToSystemBars = true;
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseDevExpress(useLocalization: true)
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("univia-pro-regular.ttf", "Univia-Pro");
                    fonts.AddFont("roboto-bold.ttf", "Roboto-Bold");
                    fonts.AddFont("roboto-regular.ttf", "Roboto");
                })
                .UseMauiMaps(); ;
            builder.Services.AddDemoApiClientService(x => x.ApiBaseAddress = "https://maui-portal.vercel.app/");
            builder.Services.AddTransient<CulturalEventsPage>();
            builder.Services.AddTransient<AskQuestionsPage>();

            return builder.Build();
        }
    }
}
