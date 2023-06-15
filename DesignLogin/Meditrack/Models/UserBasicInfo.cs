using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditrack.Models
{
    public class UserBasicInfo 
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public string RoleText { get; set; }

    }

    public enum RoleDetails
    {
        Doctor = 1,
        Patient,
        Admin,

    }
}
