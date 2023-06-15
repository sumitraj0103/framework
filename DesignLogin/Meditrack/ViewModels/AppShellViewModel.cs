using Meditrack.Views.Startup;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditrack.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        


        [ICommand]
        async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {

                Preferences.Remove(nameof(App.UserDetails));

            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}
