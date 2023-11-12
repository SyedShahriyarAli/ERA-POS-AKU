using Microsoft.AspNetCore.Components.WebView.Maui;
using ERA_POS_AKU.Data;
using Radzen;

namespace ERA_POS_AKU;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<GlobalService>();
		builder.Services.AddScoped<DialogService>();
		builder.Services.AddScoped<ContextMenuService>();
		builder.Services.AddScoped<NotificationService>();
		builder.Services.AddScoped<TooltipService>();

		return builder.Build();
	}
}
