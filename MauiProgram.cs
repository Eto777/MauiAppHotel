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
                    fonts.AddFont("DancingScript-Bold.ttf", "DancingScript-Bold");
                    fonts.AddFont("DancingScript-Medium.ttf", "DancingScript-Medium");
                    fonts.AddFont("DancingScript-Regular.ttf", "DancingScript-Regular");
                    fonts.AddFont("DancingScript-SemiBold.ttf", "DancingScript-SemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
