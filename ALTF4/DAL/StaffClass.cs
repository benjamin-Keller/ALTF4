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
        public string StaffNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public int ContactNumber { get; set; }
        public string StaffType { get; set; }
        public int DepartmentCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveStatus { get; set; }

        public StaffClass()
        {

        }


        public StaffClass( int code , string staffNumber, string name, string surname, string emailAddress, int contactNumber, string staffType, int departmentCode, string userName, string password, string activeStatus)
        {
            StaffCode = code;
            StaffNumber = staffNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
            StaffType = staffType;
            DepartmentCode = departmentCode;
            UserName = userName;
            Password = password;
            ActiveStatus = activeStatus;
        }

        public StaffClass(string staffNumber, string name, string surname, string emailAddress, int contactNumber, string staffType, int departmentCode, string userName, string password, string activeStatus)
        {
            StaffNumber = staffNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
            StaffType = staffType;
            DepartmentCode = departmentCode;
            UserName = userName;
            Password = password;
            ActiveStatus = activeStatus;
        }

        public StaffClass ( int code)
        {
            StaffCode = code;
        }
    }
}
