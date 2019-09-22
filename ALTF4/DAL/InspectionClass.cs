using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InspectionClass
    {
        public static int InspectionCode { get; set; }
        public string InspectionDate { get; set; }
        public string InspectionTime { get; set; }
        public string Comment { get; set; }
        public int VenueCode { get; set; }
        public int StaffCode { get; set; }

        public InspectionClass(string date, string time, string comment, int venueCode, int staffCode)
        {
            InspectionDate = date;
            InspectionTime = time;
            Comment = comment;
            VenueCode = venueCode;
            StaffCode = staffCode;
        }
        public InspectionClass(int code, string date, string time, string comment, int venueCode, int staffCode)
        {
            InspectionCode = code;
            InspectionDate = date;
            InspectionTime = time;
            Comment = comment;
            VenueCode = venueCode;
            StaffCode = staffCode;
        }
        public InspectionClass(int code)
        {
            InspectionCode = code;
        }
    }
}
