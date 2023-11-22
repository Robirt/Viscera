namespace Viscera.MobileUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var mauiAppBuilder = MauiApp.CreateBuilder();

        mauiAppBuilder.UseMauiApp<App>();

        return mauiAppBuilder.Build();
    }
}
