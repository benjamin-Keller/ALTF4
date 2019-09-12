using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EquipmentTypeClass
    {
        public int EquipTypeCode { get; set; }
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
    }
}
