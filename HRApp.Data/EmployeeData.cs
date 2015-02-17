using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRApp.Model;
namespace HRApp.Data
{
    public class EmployeeData
    {
        public EmployeeModel GetEployee()
        {
            using (var db = new HumanResourcesEntities())
            {
                var employee = db.Staffs.FirstOrDefault();
                var outModel = new EmployeeModel() { FirstName = employee.FName, LastName = employee.LName, Address = employee.Address1, City = employee.City, State = employee.State, Zip = employee.Zip, CellPhone = employee.Cell, Email = employee.WorkEmail, EmergencyContactName = employee.EmergencyName, EmergencyContactPhone = employee.EmergencyPhone, EmergencyContactRelation = employee.EmergencyRelation, BirthDate = employee.DOB, EmployeeType = employee.DPersonType, Ssn = employee.SSN };

                return outModel;
            }
            

        }
    }
}
