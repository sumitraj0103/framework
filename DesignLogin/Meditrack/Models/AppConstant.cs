
using Meditrack.Controls;
using Meditrack.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Meditrack.Models
{
    public class AppConstant
    {

        public async static Task AddFlyoutMenusDetails()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

            var doctorDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(DoctorDashboardPage)).FirstOrDefault();
            if (doctorDashboardInfo != null) AppShell.Current.Items.Remove(doctorDashboardInfo);

            var patientDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(PatientDashboardPage)).FirstOrDefault();
            if (patientDashboardInfo != null) AppShell.Current.Items.Remove(patientDashboardInfo);

            var adminDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(AdminDashboardPage)).FirstOrDefault();
            if (adminDashboardInfo != null) AppShell.Current.Items.Remove(adminDashboardInfo);
            //await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            if (App.UserDetails.RoleID == (int)RoleDetails.Doctor)
            {

                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Board",
                    Route = nameof(DoctorDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                     {
                                new ShellContent
                                {
                                    Icon = Icons.patient,
                                    Title = "Patients ",
                                    ContentTemplate = new DataTemplate(typeof(DoctorDashboardPage)),

                                },
                                new ShellContent
                                {
                                    Icon = Icons.pills,
                                    Title = "Medications",
                                    ContentTemplate = new DataTemplate(typeof(DoctorDashboardPage)),

                                },
                                    new ShellContent
                                {
                                    Icon = Icons.reporting,
                                    Title = "Reports",
                                    ContentTemplate = new DataTemplate(typeof(DoctorDashboardPage)),

                                },
                                    new ShellContent
                                {
                                    Icon = Icons.setting,
                                    Title = "Setting",
                                    ContentTemplate = new DataTemplate(typeof(DoctorDashboardPage)),

                                },
                                    new ShellContent
                                 {
                                    Icon = Icons.phone,
                                    Title = "Support",
                                    ContentTemplate = new DataTemplate(typeof(DoctorDashboardPage)),

                                },
                     }

                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(DoctorDashboardPage)}");
                }
            }
            if (App.UserDetails.RoleID == (int)RoleDetails.Patient)
            {

                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Board",
                    Route = nameof(PatientDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                     {
                                new ShellContent
                                {
                                    Icon = Icons.pills,
                                    Title = "Medications",
                                    ContentTemplate = new DataTemplate(typeof(PatientDashboardPage)),

                                },
                                new ShellContent
                                {
                                    Icon = Icons.reporting,
                                    Title = "Reports",
                                    ContentTemplate = new DataTemplate(typeof(PatientDashboardPage)),

                                },
                                new ShellContent
                                {
                                    Icon = Icons.setting,
                                    Title = "Setting",
                                    ContentTemplate = new DataTemplate(typeof(PatientDashboardPage)),

                                },
                                new ShellContent
                                {
                                    Icon = Icons.phone,
                                    Title = "Support",
                                    ContentTemplate = new DataTemplate(typeof(PatientDashboardPage)),

                                },
                     }

                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(PatientDashboardPage)}");
                }
            }
            if (App.UserDetails.RoleID == (int)RoleDetails.Admin)
            {

                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Board",
                    Route = nameof(AdminDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                     {
                                new ShellContent
                                {
                                    Icon = Icons.doctor,
                                    Title = "Add/Remove Doctors",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),

                                },
                                new ShellContent
                                {
                                    Icon = Icons.patient,
                                    Title = "Add/Remove Patient",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),

                                },
                                new ShellContent
                                {
                                    Icon = Icons.setting,
                                    Title = "Setting",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),

                                },
                                  new ShellContent
                                {
                                    Icon = Icons.phone,
                                    Title = "Support",
                                    ContentTemplate = new DataTemplate(typeof(AdminDashboardPage)),

                                },
                     }

                };
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync($"//{nameof(AdminDashboardPage)}");
                }
            }
        }
    }
}
