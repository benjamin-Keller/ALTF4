using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TutorRequestClass
    {
        public int RequestCode { get; set; }
        public string Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int ModuleCode { get; set; }
        public int VenueCode { get; set; }

        public TutorRequestClass(int requestCode, string date, int startTime, int endTime, int moduleCode, int venueCode)
        {
            RequestCode = requestCode;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            ModuleCode = moduleCode;
            VenueCode = venueCode;

        }
    }
}
