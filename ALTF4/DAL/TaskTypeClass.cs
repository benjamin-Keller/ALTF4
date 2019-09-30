﻿namespace DAL
{
	public class TaskTypeClass
	{
		public static int TaskTypeCode { get; set; }
		public string Name { get; set; }


		public TaskTypeClass()
		{

		}


		public TaskTypeClass(string name)
		{
			Name = name;
		}

		public TaskTypeClass(int code, string name)
		{
			TaskTypeCode = code;
			Name = name;
		}

		public TaskTypeClass(int code)
		{
			TaskTypeCode = code;
		}

	}
}
