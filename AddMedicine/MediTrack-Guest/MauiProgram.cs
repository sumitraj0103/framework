using MediTrack_Guest.Services;
using MediTrack_Guest.ViewModels;
using MediTrack_Guest.Views;

namespace MediTrack_Guest;

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

        //Services
        builder.Services.AddSingleton<IMedicationService, MedicationService>();

        // Views Registartion 
        builder.Services.AddSingleton<MedicationListPage>();
        builder.Services.AddSingleton<AddUpdateMedicationDetail>();
        //View Models
        builder.Services.AddSingleton<MedicationListPageViewModel>();
        builder.Services.AddSingleton<AddUpdateMedicationDetailViewModel>();


        return builder.Build();


	}
}
