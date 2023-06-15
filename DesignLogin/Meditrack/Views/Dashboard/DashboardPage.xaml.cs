using Meditrack.ViewModels.Dashboard;

namespace Meditrack.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}