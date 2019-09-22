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
                dbCmd.Parameters.AddWithValue("@BuildingBlockID", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@BuildingID", venue.VenueBuilding);

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

        public DataTable PopulateCmbModels()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_GetAllModules", dbConn);
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

        public DataTable GetInspection()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_DisplayAllInspection", dbConn);
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
            dbCmd = new SqlCommand("dbo.sp_DisplayAllRequestsPending", dbConn);
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
            dbCmd = new SqlCommand("dbo.sp_DisplayAllTaskType", dbConn);
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
        
        public int AddDepartment(DepartmentClass department)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddDepart", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                dbCmd.Parameters.AddWithValue("@BuildingID", department.Building);
                dbCmd.Parameters.AddWithValue("@ContactPerson", department.ContactPerson);
                dbCmd.Parameters.AddWithValue("@Email", department.Email);
                dbCmd.Parameters.AddWithValue("@ContactNumber", department.ContactNumber);

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

        public int AddEquipment(EquipmentClass equipment)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddEquip", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@EquipmentDescription", equipment.EquipmentDescription);
                dbCmd.Parameters.AddWithValue("@EquipTypeCode", equipment.EquipTypeCode);
                dbCmd.Parameters.AddWithValue("@VenueCode", equipment.VenueCode);

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

        public int AddEquipmentType(EquipmentTypeClass equipmentType)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_AddEquipType", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@TypeDescription", equipmentType.TypeDescription);

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

        public int AddInspection(InspectionClass inspection)
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

                dbCmd.Parameters.AddWithValue("@VenueCode", inspection.VenueCode);
                dbCmd.Parameters.AddWithValue("@StaffCode", inspection.StaffCode);
                dbCmd.Parameters.AddWithValue("@InspectionDate", inspection.InspectionDate);
                dbCmd.Parameters.AddWithValue("@InspectionTime", inspection.InspectionTime);
                dbCmd.Parameters.AddWithValue("@Comment", inspection.Comment);

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

        public int AddInspectionDetail(InspectionDetailClass inspectionDetail)
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

                dbCmd.Parameters.AddWithValue("@InspectionCode", inspectionDetail.InspectionCode);
                dbCmd.Parameters.AddWithValue("@EquipmentCode", inspectionDetail.EquipmentCode);
                dbCmd.Parameters.AddWithValue("@StaffCode", inspectionDetail.StaffCode);
                dbCmd.Parameters.AddWithValue("@FaultComment", inspectionDetail.FaultComment);
                dbCmd.Parameters.AddWithValue("@InspectionStatus", inspectionDetail.InspectionStatus);

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

        public int AddRequest(RequestClass request)
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

                dbCmd.Parameters.AddWithValue("@RequestDescription", request.RequestDescription);
                dbCmd.Parameters.AddWithValue("@StaffCode", request.RequestStaffCode);
                dbCmd.Parameters.AddWithValue("@StudentCode", request.RequestStudentCode);
                dbCmd.Parameters.AddWithValue("@TaskTypeCode", request.RequestTaskTypeCode);
                dbCmd.Parameters.AddWithValue("@RequestDate", request.RequestDate);
                dbCmd.Parameters.AddWithValue("@RequestTime", request.RequestTime);
                dbCmd.Parameters.AddWithValue("@AssignedStaffCode", request.RequestAssignedStaffCode);
                dbCmd.Parameters.AddWithValue("@RequestStatus", request.RequestStatus);

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

        public int AddStaff(StaffClass staff)
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

                dbCmd.Parameters.AddWithValue("@StaffNumber", StaffClass.StaffNumber);
                dbCmd.Parameters.AddWithValue("@FirstName", staff.Name);
                dbCmd.Parameters.AddWithValue("@LastName", staff.Surname);
                dbCmd.Parameters.AddWithValue("@Email", staff.EmailAddress);
                dbCmd.Parameters.AddWithValue("@ContactNumber", staff.ContactNumber);
                dbCmd.Parameters.AddWithValue("@StaffType", staff.StaffType);
                dbCmd.Parameters.AddWithValue("@DepartmentCode", staff.DepartmentCode);

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

        public int UpdateStaff(StaffClass staff)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_UpdateStaff", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;


                dbCmd.Parameters.AddWithValue("@StaffCode", DAL.StaffClass.StaffCode);
                dbCmd.Parameters.AddWithValue("@StaffNumber", StaffClass.StaffNumber);
                dbCmd.Parameters.AddWithValue("@FirstName", staff.Name);
                dbCmd.Parameters.AddWithValue("@LastName", staff.Surname);
                dbCmd.Parameters.AddWithValue("@Email", staff.EmailAddress);
                dbCmd.Parameters.AddWithValue("@ContactNumber", staff.ContactNumber);
                dbCmd.Parameters.AddWithValue("@StaffType", staff.StaffType);
                dbCmd.Parameters.AddWithValue("@DepartmentCode", staff.DepartmentCode);

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

        public DataTable SelectForUpdateStaff(StaffClass staffed)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateStaff", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@StaffCode", DAL.StaffClass.StaffCode);

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



        public int AddStudent(StudentClass student)
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

                dbCmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                dbCmd.Parameters.AddWithValue("@Name", student.Name);
                dbCmd.Parameters.AddWithValue("@Surname", student.Surname);
                dbCmd.Parameters.AddWithValue("@Email", student.EmailAddress);

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

        

        public int AddTaskType(TaskTypeClass taskType)
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

                dbCmd.Parameters.AddWithValue("@VenueDescription", taskType.Name);

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

        public int AddTutorRequest(TutorRequestClass tutorRequest)
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

                dbCmd.Parameters.AddWithValue("@RequestCode", TutorRequestClass.RequestCode);
                dbCmd.Parameters.AddWithValue("@TutorRequestDate", tutorRequest.Date);
                dbCmd.Parameters.AddWithValue("@StartTime", tutorRequest.StartTime.ToShortTimeString());
                dbCmd.Parameters.AddWithValue("@EndTime", tutorRequest.EndTime.ToShortTimeString());
                dbCmd.Parameters.AddWithValue("@ModuleCode", tutorRequest.ModuleCode);
                dbCmd.Parameters.AddWithValue("@VenueCode", tutorRequest.VenueCode);

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

        //public int AddUsers(UsersClass user)
        //{
        //    try
        //    {
        //        dbConn.Open();
        //    }
        //    catch { }

        //    int x;
        //    try
        //    {

        //        dbCmd = new SqlCommand("dbo.sp_AddUser", dbConn);
        //        dbCmd.CommandType = CommandType.StoredProcedure;

        //        dbCmd.Parameters.AddWithValue("@Username", user.Username);
        //        dbCmd.Parameters.AddWithValue("@Password", user.Password);
        //        dbCmd.Parameters.AddWithValue("@Role", user.Role);
        //        //dbCmd.Parameters.AddWithValue("@UserAdmin", user.VenueBuildingBlock);

        //        x = dbCmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        return 0;
        //    }

        //    try
        //    {
        //        dbConn.Close();
        //    }
        //    catch { }
        //    return x;
        //}

        public DataTable GetLogin(LoginClass login)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            
            dbCmd = new SqlCommand("dbo.sp_Login", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Username", login.Username);
            dbCmd.Parameters.AddWithValue("@StaffPassword", login.Password);

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

        public int UpdateStudent(StudentClass studentClass)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            int x;

            try
            {
                dbCmd = new SqlCommand("dbo.sp_UpdateStudent", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@StudentCode", DAL.StudentClass.StudentCode);
                dbCmd.Parameters.AddWithValue("@FirstName", studentClass.Name);
                dbCmd.Parameters.AddWithValue("@LastName", studentClass.Surname);
                dbCmd.Parameters.AddWithValue("@Email", studentClass.EmailAddress);
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

        public DataTable SelectedForUpdateStudent(StudentClass classes)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateStudent", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@StudentCode", DAL.StudentClass.StudentCode);

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
        public int UpdateVenue(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_UpdateVenue", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueCode", DAL.VenueClass.VenueCode);
                dbCmd.Parameters.AddWithValue("@VenueDescription", venue.VenueDescription);
                dbCmd.Parameters.AddWithValue("@Capacity", venue.VenueCapacity);
                dbCmd.Parameters.AddWithValue("@DoorNo", venue.VenueDoorNo);
                dbCmd.Parameters.AddWithValue("@BuildingBlockID", venue.VenueBuildingBlock);
                dbCmd.Parameters.AddWithValue("@BuildingID", venue.VenueBuilding);
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

        public DataTable SelectedForUpdateVenue(VenueClass venue)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            
            

                dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateVenue", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@VenueCode", DAL.VenueClass.VenueCode);
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

        public int UpdateDepartment(DepartmentClass dep)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_UpdateDepart", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@DepartmentCode", DAL.DepartmentClass.DepartmentCode);
                dbCmd.Parameters.AddWithValue("@DepartmentName", dep.DepartmentName);
                dbCmd.Parameters.AddWithValue("@BuildingID", dep.Building);
                dbCmd.Parameters.AddWithValue("@ContactPerson", dep.ContactPerson);
                dbCmd.Parameters.AddWithValue("@Email", dep.Email);
                dbCmd.Parameters.AddWithValue("@ContactNumber", dep.ContactNumber);
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

        

        public DataTable SelectedForUpdateDepartment(DepartmentClass dep)
        {
            try
            {
                dbConn.Open();
            }
            catch { }



            dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateDepartment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@DepartmentCode", DAL.DepartmentClass.DepartmentCode);
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

        public int UpdateEquipment(EquipmentClass equipment)
        {
            try
            {
                dbConn.Open();
            }
            catch { }

            int x;
            try
            {

                dbCmd = new SqlCommand("dbo.sp_UpdateEquip", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@EquipmentCode", DAL.EquipmentClass.EquipmentCode);
                dbCmd.Parameters.AddWithValue("@EquipmentDescription", equipment.EquipmentDescription);
                dbCmd.Parameters.AddWithValue("@VenueCode", equipment.VenueCode);
                dbCmd.Parameters.AddWithValue("@EquipTypeCode", equipment.EquipTypeCode);
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

       

        public DataTable SelectedForUpdateEquipment(EquipmentClass equipment)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateEquipment", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@EquipmentCode", DAL.EquipmentClass.EquipmentCode);
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

        public int UpdateTaskType(TaskTypeClass taskType)
        {

            try
            {
                dbConn.Open();
            }
            catch { }

            int x;

            try
            {
                dbCmd = new SqlCommand("dbo.sp_UpdateTaskType", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@TaskTypeCode", DAL.TaskTypeClass.TaskTypeCode);
                dbCmd.Parameters.AddWithValue("@Name", taskType.Name);
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

        

        public DataTable SelectedForUpdateTaskType(TaskTypeClass task)
        {
            try
            {
                dbConn.Open();

            }
            catch
            {

            }
            dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateTaskType", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@TaskTypeCode", DAL.TaskTypeClass.TaskTypeCode);
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
        public int UpdateTutorRequest(TutorRequestClass tutor)
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            int x;
            try
            {
                dbCmd = new SqlCommand("dbo.sp_UpdateTutorRequest", dbConn);
                dbCmd.CommandType = CommandType.StoredProcedure;

                dbCmd.Parameters.AddWithValue("@RequestCode", DAL.TutorRequestClass.RequestCode);
                dbCmd.Parameters.AddWithValue("@TutorRequestDate", tutor.Date);
                dbCmd.Parameters.AddWithValue("@StartTime", tutor.StartTime);
                dbCmd.Parameters.AddWithValue("@EndTime", tutor.EndTime);
                dbCmd.Parameters.AddWithValue("@ModuleCode", tutor.ModuleCode);
                dbCmd.Parameters.AddWithValue("@VenueCode", tutor.VenueCode);

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
        public DataTable SelectedForUpdateTutorRequest(TutorRequestClass request)
        {
            try
            {
                dbConn.Open();
            }
            catch { }


            dbCmd = new SqlCommand("dbo.sp_SelectedForUpdateTutorRequest", dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@RequestCode", DAL.TutorRequestClass.RequestCode);
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
    }
}
