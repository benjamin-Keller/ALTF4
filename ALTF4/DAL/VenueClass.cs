namespace DAL
{
	public class VenueClass
	{
		public static int VenueCode { get; set; }

		public string VenueDescription { get; set; }

		public int VenueCapacity { get; set; }

		public int VenueDoorNo { get; set; }

		public int VenueBuildingBlock { get; set; }

		public int VenueBuilding { get; set; }

		public VenueClass()
		{

		}

		public VenueClass(string description, int capacity, int doorNo, int buildingBlock, int building)
		{
			VenueDescription = description;
			VenueCapacity = capacity;
			VenueDoorNo = doorNo;
			VenueBuildingBlock = buildingBlock;
			VenueBuilding = building;
		}

		public VenueClass(int code, string description, int capacity, int doorNo, int buildingBlock, int building)
		{
			VenueCode = code;
			VenueDescription = description;
			VenueCapacity = capacity;
			VenueDoorNo = doorNo;
			VenueBuildingBlock = buildingBlock;
			VenueBuilding = building;
		}

		public VenueClass(int code)
		{
			VenueCode = code;
		}

	}
}
