using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VenueClass
    { 
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
        
    }
}
