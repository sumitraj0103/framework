using MediTrack_Guest.ViewModels;

namespace MediTrack_Guest.Views;

public partial class AddUpdateMedicationDetail : ContentPage
{
	public AddUpdateMedicationDetail(AddUpdateMedicationDetailViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}