using MediTrack_Guest.Models;
using MediTrack_Guest.Services;
using MediTrack_Guest.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MediTrack_Guest.ViewModels
{
    [QueryProperty(nameof(MedicationDetail),"MedicationDetail")]
    public partial class AddUpdateMedicationDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        public MedicationModel _medicationDetail = new MedicationModel();
        private readonly IMedicationService _medicationService;
        public AddUpdateMedicationDetailViewModel(IMedicationService medicationService) 
        { 
        
            _medicationService = medicationService;
        
        }
       

        [ICommand]
        public async void AddUpdateMedication()
        {
            int response = -1;
            if(MedicationDetail.MedicineID >0 )
            {
                response = await _medicationService.UpdateMedication(MedicationDetail);
            }
            else
            {
                response = await _medicationService.AddMedication(new Models.MedicationModel
                {

                    Medicine = _medicationDetail.Medicine,
                    Symptom = _medicationDetail.Symptom,
                    Allergic = _medicationDetail.Allergic,
                });

            }

            if (response >0)
            {

                await Shell.Current.DisplayAlert("Medication Added!", "Record Saved", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Not Added", "Something Need to be fixed", "OK");

            }
        }
    }
}
