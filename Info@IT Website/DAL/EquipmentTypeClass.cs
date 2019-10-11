namespace DAL
{
	public class EquipmentTypeClass
	{
		public static int EquipTypeCode { get; set; }
		public string TypeDescription { get; set; }

		public EquipmentTypeClass(string desc)
		{
			TypeDescription = desc;
		}

		public EquipmentTypeClass(int code, string desc)
		{
			EquipTypeCode = code;
			TypeDescription = desc;
		}

		public EquipmentTypeClass(int code)
		{
			EquipTypeCode = code;
		}
	}
}
