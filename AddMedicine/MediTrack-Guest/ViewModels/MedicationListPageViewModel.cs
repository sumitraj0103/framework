using MediTrack_Guest.Models;
using MediTrack_Guest.Services;
using MediTrack_Guest.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack_Guest.ViewModels
{
    public partial class MedicationListPageViewModel : ObservableObject
    {
        public ObservableCollection<MedicationModel> Medications { get; set; } = new ObservableCollection<MedicationModel>();

        private readonly IMedicationService _medicationService;
        public MedicationListPageViewModel(IMedicationService medicationService)
        {
            _medicationService = medicationService;
        }

        [ICommand]
        private async void GetMedicationList()
        {

            var MedicationList = await _medicationService.GetMedicationList();
            if (MedicationList?.Count > 0)
            {
                Medications.Clear();
                foreach (var medication in MedicationList)
                {
                    Medications.Add(medication);
                }

            }
        }

        [ICommand]
        public async void AddUpdateMedication()
        {

            await AppShell.Current.GoToAsync(nameof(AddUpdateMedicationDetail));
        }

        [ICommand]
        public async void DisplayAction(MedicationModel medicationModel)
        {

            var response = await AppShell.Current.DisplayActionSheet("Select Option", "Ok",null,"Edit","Delete");
            if(response =="Edit")
            {
                var navParam= new Dictionary<string, object>();
                navParam.Add("MedicationDetail", medicationModel);
                await AppShell.Current.GoToAsync(nameof(AddUpdateMedicationDetail), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse= await _medicationService.DeleteMedication(medicationModel);
                if(delResponse > 0)
                {

                    GetMedicationList();
                }
            }
        }

    }
}
