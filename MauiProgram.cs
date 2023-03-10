using KevinRosero_ExamenFinal.Data;
using KevinRosero_ExamenFinal.Service;

namespace KevinRosero_ExamenFinal;

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
        string dbPath = FileAccessHelper.GetLocalFilePath("perros.db3");
        builder.Services.AddSingleton<PerrosCall>(s => ActivatorUtilities.CreateInstance<PerrosCall>(s));
        builder.Services.AddSingleton<PerroDataBaseKR>(s => ActivatorUtilities.CreateInstance<PerroDataBaseKR>(s, dbPath));
        return builder.Build();
	}
}
