using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentClass
    {
        public static int StudentCode { get; set; }
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }


        public StudentClass(string studentNumber, string name, string surname, string emailAddress)
        {
            StudentNumber = studentNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
        }

        public StudentClass(int code, string studentNumber, string name, string surname, string emailAddress)
        {
            StudentCode = code;
            StudentNumber = studentNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
        }

        public StudentClass( int code)
        {
            StudentCode = code;
        }
    }
}
