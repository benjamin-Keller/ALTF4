﻿using System;
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
        SqlConnection dbConn = new SqlConnection(@"Server=tcp:altf4-projects.database.windows.net,1433;Initial Catalog=Info@IT;Persist Security Info=False;User ID=altf4_F4_Admin;Password=WeaDee26;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //For Ben (so I can connect to the database for now)
		//SqlConnection dbConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zhero\source\repos\zhero42\ALTF4\ALTF4\Info@IT\App_Data\info-IT_DB.mdf;Integrated Security=True");
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
                
                dbCmd = new SqlCommand("dbo.sp_AddVenue", dbConn);
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
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_GetBuilding", dbConn);
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

        public DataTable PopulateCmbBuildingBlock()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_GetBuildingblock", dbConn);
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

        public DataTable GetDepartment()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayAllDepart", dbConn);
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

        public DataTable GetEquipment()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayEquip", dbConn);
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

        public DataTable GetEquipmentType()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayEquipmentType", dbConn);
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

        public DataTable GetInspectionDetail()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayInspectionFaults", dbConn);
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

        public DataTable GetRequests()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayLabRequests", dbConn);
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

        public DataTable GetStaff()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayAllStaff", dbConn);
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

        public DataTable GetStudent()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayAllStudents", dbConn);
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

        public DataTable GetTasktype()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayRequestModules", dbConn);
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

        public DataTable GetTutorRequest()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayRequestTutor", dbConn);
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
        
        public int AddDepartment(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddDepartment", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddEquipment(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddEquipment", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddEquipmentType(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddEquipmentType", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddInspection(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddInspection", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddInspectionDetail(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddInspectionDetail", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddRequest(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddRequest", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddStaff(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddStaff", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddStudent(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddStudent", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddTaskType(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddTaskType", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddTutorRequest(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddTutorRequest", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlock", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@Building", venue.VenueBuilding);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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

        public int AddUsers(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddUser", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@Username", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Password", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@Role", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@UserAdmin", venue.VenueBuildingBlock);

                x = dbCmd.ExecuteNonQuery();
            }
            catch (Exception e)
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


    }
}
