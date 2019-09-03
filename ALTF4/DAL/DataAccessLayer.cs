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
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayVenue", dbConn);
            //dbCmd.CommandText = "sp_DisplayVenue";
            //dbCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(dbCmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {
                dbConn.Close();
            }
            catch { }
            return dt;
        }

        public int AddVenue(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {
                //VenueClass venue = new VenueClass();
                dbCmd = new SqlCommand("dbo.sp_AddVenue", dbConn);
                //dbCmd.CommandText = "dbo.sp_AddVenue";
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return 0;
            }

            try
            {
                dbConn.Close();
            }
            catch { }
            return x;
        }

        public DataTable PopulateCmbBuilding()
        {
            dbCmd = new SqlCommand("dbo.sp_PopulateBuilding", dbConn);
            //dbCmd.CommandText = "sp_DisplayVenue";
            //dbCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(dbCmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
