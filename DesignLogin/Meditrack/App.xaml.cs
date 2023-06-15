using Meditrack.Handlers;
using Meditrack.Models;

namespace Meditrack;

public partial class App : Application
{
	public static UserBasicInfo UserDetails;
	public App()
	{
		InitializeComponent();
		
		MainPage = new AppShell();
	}
}
