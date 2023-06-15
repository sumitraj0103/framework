using MediTrack_Guest.Views;

namespace MediTrack_Guest;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddUpdateMedicationDetail), typeof(AddUpdateMedicationDetail));
	}
}
