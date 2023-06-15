using Meditrack.Controls;
using Meditrack.Models;
using Meditrack.Views.Dashboard;
using Meditrack.Views.Startup;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditrack.ViewModels.Startup
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }
        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");

            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                // Navigate to LoginPage
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
            {
                //Navigate to Dashboard Page
                var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(userDetailsStr);
                App.UserDetails = userInfo;
                await AppConstant.AddFlyoutMenusDetails();
            }
        }
    }
}
