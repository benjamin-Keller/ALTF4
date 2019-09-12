using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentClass
    {
        public int DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Building { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public DepartmentClass(string name, string building, string contactPerson, string contactNumber, string email)
        {
            DepartmentName = name;
            Building = building;
            ContactPerson = contactPerson;
            ContactNumber = contactNumber;
            Email = email;
        }

        public DepartmentClass(int code, string name, string building, string contactPerson, string contactNumber, string email)
        {
            DepartmentCode = code;
            DepartmentName = name;
            Building = building;
            ContactPerson = contactPerson;
            ContactNumber = contactNumber;
            Email = email;
        }
    }
}
