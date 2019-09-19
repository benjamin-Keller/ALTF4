using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EquipmentClass
    {
        public static int EquipmentCode { get; set; }
        public string EquipmentDescription { get; set; }
        public int VenueCode { get; set; }
        public int EquipTypeCode { get; set; }

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
    }
}
