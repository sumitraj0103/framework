using Meditrack.Models;
using Meditrack.ViewModels;
using Meditrack.Views.Dashboard;

namespace Meditrack;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
		//Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));

    }
}
