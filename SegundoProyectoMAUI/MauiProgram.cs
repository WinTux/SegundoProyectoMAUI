using Microsoft.Extensions.Logging;
using SegundoProyectoMAUI.Pages;
using ZXing.Net.Maui;
using CommunityToolkit.Maui;

namespace SegundoProyectoMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseBarcodeReader()
			.UseMauiCommunityToolkit()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddTransient<SegundaPage>();
        builder.Services.AddTransient<TerceraPage>();
        builder.Services.AddTransient<CuartaPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
