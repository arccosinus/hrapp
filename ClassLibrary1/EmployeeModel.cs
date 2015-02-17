using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp.Model
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KnowAsNick { get; private set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }

        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactRelation{ get; set; }
        public DateTime? BirthDate { get; set; }
        public string Ethnicity { get; set; }
        public DateTime JobStartDate { get; set; }
        public string EmployeeType { get; set; }
        public string Ssn { get; set; }

    }
}
