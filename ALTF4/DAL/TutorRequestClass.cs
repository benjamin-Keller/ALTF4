using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TutorRequestClass
    {
        public static int RequestCode { get; set; }
        public DateTime Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int ModuleCode { get; set; }
        public int VenueCode { get; set; }

        public TutorRequestClass()
        {

        }

        public TutorRequestClass(int requestCode, DateTime date, string startTime, string endTime, int moduleCode, int venueCode)
        {
            RequestCode = requestCode;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            ModuleCode = moduleCode;
            VenueCode = venueCode;

        }

        public TutorRequestClass (int requestCode)
        {
            RequestCode = requestCode;
        }
    }
}
