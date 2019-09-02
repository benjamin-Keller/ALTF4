using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    
    public class DataAccessLayer
    {
        SqlConnection dbConn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Info@IT;Integrated Security=SSPI;");
        SqlCommand dbCmd;
        
        public DataTable GetVenues()
        {
            dbCmd = new SqlCommand("dbo.sp_DisplayVenue", dbConn);
            //dbCmd.CommandText = "sp_DisplayVenue";
            //dbCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(dbCmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        //public int AddVenue()
        //{
        //    dbCmd = new SqlCommand("dbo.sp_DisplayVenue", dbConn);
        //}
    }
}
