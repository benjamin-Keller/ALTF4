using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_IT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

    }

    public class Venues
    {
        public string VenueCode{ get; set; }

        public string VenueDescription { get; set; }

        public string VenueCapacity { get; set; }

        public string VenueDoorNo { get; set; }

        public string VenueBuildingBlock { get; set; }

        public string VenueBuilding { get; set; }

        public Venues()
        {

        }

        public Venues(string code, string description, string capacity, string doorNo, string buildingBlock, string building)
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
