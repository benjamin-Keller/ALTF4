using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffClass
    {
        public static int StaffCode { get; set; }
        public  int StaffNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public int ContactNumber { get; set; }
        public string StaffType { get; set; }
        public int DepartmentCode { get; set; }

        

        public StaffClass( int code , int staffNumber, string name, string surname, string emailAddress, int contactNumber, string staffType, int departmentCode)
        {
            StaffCode = code;
            StaffNumber = staffNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
            StaffType = staffType;
            DepartmentCode = departmentCode;
        }

        public StaffClass(int staffNumber, string name, string surname, string emailAddress, int contactNumber, string staffType, int departmentCode)
        {
            StaffNumber = staffNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
            StaffType = staffType;
            DepartmentCode = departmentCode;
        }
        public StaffClass ( int code)
        {
            StaffCode = code;
        }
    }
}
