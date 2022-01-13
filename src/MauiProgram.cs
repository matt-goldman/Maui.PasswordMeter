using Maui.PasswordMeter.Services;
using Maui.PasswordMeter.ViewModels;

namespace Maui.PasswordMeter;

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
				fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<PasswordValidationService>();

		return builder.Build();
	}
}
