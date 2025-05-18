using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("Lato-Regular.ttf", "Lato");
                    fonts.AddFont("Silkscreen-Regular.ttf", "Silkscreen");
                    fonts.AddFont("PinyonScript-Regular.ttf", "PinyonScript");
                    fonts.AddFont("DeliusUnicase-Regular.ttf", "DeliusUnicase");
                    fonts.AddFont("Exo2-Regular.ttf", "Exo2");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
