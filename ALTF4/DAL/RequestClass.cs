using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RequestClass
    {
        public static int RequestCode { get; set; }
        public string RequestDescription { get; set; }
        public int RequestStaffCode { get; set; }
        public int RequestStudentCode { get; set; }
        public int RequestTaskTypeCode { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime RequestTime { get; set; }
        public int RequestAssignedStaffCode { get; set; }
        public string RequestStatus { get; set; }

        public RequestClass(string description, int staffCode, int studentCode, int taskTypeCode, DateTime date, DateTime time, int assignedStaffCode, string status)
        {
            RequestDescription = description;
            RequestStaffCode = staffCode;
            RequestStudentCode = studentCode;
            RequestTaskTypeCode = taskTypeCode;
            RequestDate = date;
            RequestTime = time;
            RequestAssignedStaffCode = assignedStaffCode;
            RequestStatus = status;



        }
    }
}
