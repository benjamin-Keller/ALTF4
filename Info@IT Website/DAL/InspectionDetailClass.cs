namespace DAL
{
	public class InspectionDetailClass
	{
		public static int InspectionDetailCode { get; set; }
		public int InspectionCode { get; set; }
		public int EquipmentCode { get; set; }
		public int StaffCode { get; set; }
		public string FaultComment { get; set; }
		public string InspectionStatus { get; set; }

		public InspectionDetailClass()
		{

		}

		public InspectionDetailClass(int inspectionCode, int equipmentCode, int staffCode, string comment, string status)
		{
			InspectionCode = inspectionCode;
			EquipmentCode = equipmentCode;
			StaffCode = staffCode;
			FaultComment = comment;
			InspectionStatus = status;
		}

		public InspectionDetailClass(int code, int inspectionCode, int equipmentCode, int staffCode, string comment, string status)
		{
			InspectionDetailCode = code;
			InspectionCode = inspectionCode;
			EquipmentCode = equipmentCode;
			StaffCode = staffCode;
			FaultComment = comment;
			InspectionStatus = status;
		}

		public InspectionDetailClass(int code)
		{
			InspectionDetailCode = code;
		}
	}
}
