using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack_Guest.Models
{
    public class MedicationModel
    {
        [PrimaryKey, AutoIncrement]
        public int MedicineID { get; set; }

        public string Medicine { get; set; }

        public string Symptom { get; set; }
        public string Allergic { get; set; }


    }
}
