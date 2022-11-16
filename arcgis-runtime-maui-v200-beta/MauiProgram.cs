using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Maui;

namespace arcgis_runtime_maui_v200_beta;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		ArcGISRuntimeEnvironment.Initialize();

        Routing.RegisterRoute(nameof(MapPage), typeof(MapPage));

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseArcGISRuntime()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        return builder.Build();
	}
}
