using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Venue
    { 
        public string VenueCode { get; set; }

        public string VenueDescription { get; set; }

        public string VenueCapacity { get; set; }

        public string VenueDoorNo { get; set; }

        public string VenueBuildingBlock { get; set; }

        public string VenueBuilding { get; set; }

        public Venue()
        {

        }

        public Venue(string code, string description, string capacity, string doorNo, string buildingBlock, string building)
        {
            VenueCode = code;
            VenueDescription = description;
            VenueCapacity = capacity;
            VenueDoorNo = doorNo;
            VenueBuildingBlock = buildingBlock;
            VenueBuilding = building;

        }
        
    }
}
