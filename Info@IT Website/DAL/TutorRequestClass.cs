using System;

namespace DAL
{
	public class TutorRequestClass
	{
		public static int RequestCode { get; set; }
        public static int TutorRequestCode { get; set; }
        public DateTime Date { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }
		public int ModuleCode { get; set; }
		public int VenueCode { get; set; }
        public string Status { get; set; }

		public TutorRequestClass()
		{

		}

        public TutorRequestClass(int requestCode, DateTime date, string startTime, string endTime, int moduleCode, int venueCode, string status)
        {
            RequestCode = requestCode;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            ModuleCode = moduleCode;
            VenueCode = venueCode;
            Status = status;
        }
        public TutorRequestClass(int tutorRequestCode,int requestCode, DateTime date, string startTime, string endTime, int moduleCode, int venueCode, string status)
        {
            TutorRequestCode = tutorRequestCode;
            RequestCode = requestCode;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            ModuleCode = moduleCode;
            VenueCode = venueCode;
            Status = status;
        }

        public TutorRequestClass(int requestCode)
		{
			TutorRequestCode = requestCode;
		}
	}
}
