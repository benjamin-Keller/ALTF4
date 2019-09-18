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
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ModuleCode { get; set; }
        public int VenueCode { get; set; }

        public TutorRequestClass(int requestCode, DateTime date, DateTime startTime, DateTime endTime, int moduleCode, int venueCode)
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
