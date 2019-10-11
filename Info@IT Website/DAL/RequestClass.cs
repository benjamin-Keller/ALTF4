﻿using System;

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
		public string RequestTime { get; set; }
		public int RequestAssignedStaffCode { get; set; }
		public string RequestStatus { get; set; }

		public RequestClass()
		{

		}

		public RequestClass(string description, int staffCode, int studentCode, int taskTypeCode, DateTime date, string time, int assignedStaffCode, string status)
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

		public RequestClass(int code, string description, int staffCode, int studentCode, int taskTypeCode, DateTime date, string time, int assignedStaffCode, string status)
		{
			RequestCode = code;
			RequestDescription = description;
			RequestStaffCode = staffCode;
			RequestStudentCode = studentCode;
			RequestTaskTypeCode = taskTypeCode;
			RequestDate = date;
			RequestTime = time;
			RequestAssignedStaffCode = assignedStaffCode;
			RequestStatus = status;
		}

		public RequestClass(int code)
		{
			RequestCode = code;
		}
	}
}
