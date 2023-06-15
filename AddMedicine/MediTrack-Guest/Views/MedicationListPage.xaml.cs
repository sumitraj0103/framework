using MediTrack_Guest.ViewModels;

namespace MediTrack_Guest.Views;

public partial class MedicationListPage : ContentPage
{
	private MedicationListPageViewModel _viewMode; 
	public MedicationListPage(MedicationListPageViewModel viewModel)
	{
		InitializeComponent();
		_viewMode = viewModel;
		this.BindingContext = viewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
		_viewMode.GetMedicationListCommand.Execute(null);
    }
}