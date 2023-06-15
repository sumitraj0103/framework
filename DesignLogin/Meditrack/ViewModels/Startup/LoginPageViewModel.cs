using Meditrack.Controls;
using Meditrack.Models;
using Meditrack.Views.Dashboard;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Meditrack.ViewModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;


        [ICommand]
        async void Login()
        {
            if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            {
                //calling api

                // doctor role, patient role, admin role

                var userDetails = new UserBasicInfo();
                userDetails.Email = Email;
                userDetails.FullName = "SumitRaj";
                if( Email.ToLower().Contains("dt"))
                {
                    userDetails.RoleID = (int)RoleDetails.Doctor;
                    userDetails.RoleText = "Doctor";
                }
                else if (Email.ToLower().Contains("pt"))
                {
                    userDetails.RoleID = (int)RoleDetails.Patient;
                    userDetails.RoleText = "Patient";
                }
                else
                {
                    userDetails.RoleID = (int)RoleDetails.Admin;
                    userDetails.RoleText = "Admin";
                }

              
                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {

                    Preferences.Remove(nameof(App.UserDetails));

                }
                string userDetailstr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailstr);
                App.UserDetails = userDetails;
                await AppConstant.AddFlyoutMenusDetails();

            }
          
        }
    }
}
