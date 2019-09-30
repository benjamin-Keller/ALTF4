namespace DAL
{
	public class DepartmentClass
	{
		public static int DepartmentCode { get; set; }
		public string DepartmentName { get; set; }
		public int Building { get; set; }
		public string ContactPerson { get; set; }
		public string ContactNumber { get; set; }
		public string Email { get; set; }

		public DepartmentClass()
		{

		}

		public DepartmentClass(string name, int building, string contactPerson, string email, string contactNumber)
		{
			DepartmentName = name;
			Building = building;
			ContactPerson = contactPerson;
			ContactNumber = contactNumber;
			Email = email;
		}

		public DepartmentClass(int code, string name, int building, string contactPerson, string email, string contactNumber)
		{
			DepartmentCode = code;
			DepartmentName = name;
			Building = building;
			ContactPerson = contactPerson;
			ContactNumber = contactNumber;
			Email = email;
		}

		public DepartmentClass(int code)
		{
			DepartmentCode = code;
		}
	}
}
