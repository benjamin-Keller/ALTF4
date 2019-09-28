using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class GeneralLibrary
    {
        //This is where we add any Methods that we need
        DataAccessLayer dal = new DataAccessLayer();
        public DataTable PopulateCmbBuilding()
        {
            
            return dal.PopulateCmbBuilding();
        }

    }
}
