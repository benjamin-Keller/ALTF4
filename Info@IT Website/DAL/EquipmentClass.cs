namespace DAL
{
	public class EquipmentClass
	{
		public static int EquipmentCode { get; set; }
		public string EquipmentDescription { get; set; }
		public int VenueCode { get; set; }
		public int EquipTypeCode { get; set; }

		public EquipmentClass()
		{

		}

		public EquipmentClass(string desc, int venueCode, int equipTypeCode)
		{
			EquipmentDescription = desc;
			VenueCode = venueCode;
			EquipTypeCode = equipTypeCode;
		}

		public EquipmentClass(int code, string desc, int venueCode, int equipTypeCode)
		{
			EquipmentCode = code;
			EquipmentDescription = desc;
			VenueCode = venueCode;
			EquipTypeCode = equipTypeCode;
		}

		public EquipmentClass(int code)
		{
			EquipmentCode = code;
		}
	}
}
