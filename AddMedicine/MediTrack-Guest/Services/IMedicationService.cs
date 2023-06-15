using MediTrack_Guest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack_Guest.Services
{
    public interface IMedicationService
    {
        Task<List<MedicationModel>> GetMedicationList();

        Task<int> AddMedication(MedicationModel medicationModel);

        Task<int> DeleteMedication(MedicationModel medicationModel);

        Task<int> UpdateMedication(MedicationModel medicationModel);
       

    }
}
