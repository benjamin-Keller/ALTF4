using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentClass
    {
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }


        public StudentClass(int studentNumber, string name, string surname, string emailAddress)
        {
            StudentNumber = studentNumber;
            Name = name;
            Surname = surname;
            EmailAddress = emailAddress;
        }
    }
}
