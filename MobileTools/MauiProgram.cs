using Microsoft.Extensions.Logging;
using MobileTools.ViewModels;
using MobileTools.Views;

namespace MobileTools;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<BusinessInvestmentCalculator>();
		builder.Services.AddSingleton<CompoundInterestCalculator>();
        builder.Services.AddSingleton<CompoundInterestCalculatorViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

