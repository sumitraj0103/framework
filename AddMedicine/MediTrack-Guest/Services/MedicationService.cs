using MediTrack_Guest.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack_Guest.Services
{
    public class MedicationService : IMedicationService
    {


        private SQLiteAsyncConnection _dbconnection;
        public MedicationService() {

            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbconnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Medication.db3");
                _dbconnection = new SQLiteAsyncConnection(dbPath);
               await _dbconnection.CreateTableAsync<MedicationModel>();

            }

        }
        public Task<int> AddMedication(MedicationModel medicationModel)
        {
            return _dbconnection.InsertAsync(medicationModel);
        }

        public Task<int> DeleteMedication(MedicationModel medicationModel)
        {
            return _dbconnection.DeleteAsync(medicationModel);
        }

        public async Task<List<MedicationModel>> GetMedicationList()
        {
            var medicationList = await _dbconnection.Table<MedicationModel>().ToListAsync();
            return medicationList;
        }

        public Task<int> UpdateMedication(MedicationModel medicationModel)
        {
            return _dbconnection.UpdateAsync(medicationModel);
        }

    
    }
}
