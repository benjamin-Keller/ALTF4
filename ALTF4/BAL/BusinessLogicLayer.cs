using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;


namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public DataTable GetVenues()
        {
            return dal.GetVenues();
        }

        public int AddVenue(VenueClass venue)
        {
            return dal.AddVenue(venue);
        }

        public int UpdateVenue(VenueClass venue)
        {
            return dal.UpdateVenue(venue);
        }

        public DataTable SelectedForUpdateVenue(VenueClass VenueCode)
        {
            return dal.SelectedForUpdateVenue(VenueCode);
        }

        public DataTable  SelectedForUpdateTaskType( TaskTypeClass taskTypeClass)
        {
            return dal.SelectedForUpdateTaskType(taskTypeClass);
        }

        public DataTable GetDepartment()
        {
            return dal.GetDepartment();
        }

        public int UpdateDepartment(DepartmentClass dep)
        {
            return dal.UpdateDepartment(dep);
        }

       

        public int UpdateTaskType (TaskTypeClass tasky)
        {
            return dal.UpdateTaskType(tasky);
        }
        public DataTable SelectedForUpdateDepartment(DepartmentClass DepartmentCode)
        {
            return dal.SelectedForUpdateDepartment(DepartmentCode);
        }

        public DataTable GetEquipment()
        {
            return dal.GetEquipment();
        }

        public int UpdateEquipment(EquipmentClass equipment)
        {
            return dal.UpdateEquipment(equipment);
        }

        public DataTable SelectedForUpdateEquipment(EquipmentClass EquipmentCode)
        {
            return dal.SelectedForUpdateEquipment(EquipmentCode);
        }

        public DataTable GetEquipmentType()
        {
            return dal.GetEquipmentType();
        }

        public DataTable GetInspection()
        {
            return dal.GetInspection();
        }

        public DataTable GetInspectionDetail()
        {
            return dal.GetInspectionDetail();
        }

        public DataTable GetRequests()
        {
            return dal.GetRequests();
        }

        public DataTable GetStaff()
        {
            return dal.GetStaff();
        }

        public DataTable GetStudent()
        {
            return dal.GetStudent();
        }

        public int UpdateStudent(StudentClass ST)
        {
            return dal.UpdateStudent(ST);
        }
        public DataTable SelectedForUpdateStudent(StudentClass CN)
        {
            return dal.SelectedForUpdateStudent(CN);
        }
        public DataTable GetTasktype()
        {
            return dal.GetTasktype();
        }

        public DataTable GetTutorRequest()
        {
            return dal.GetTutorRequest();
        }
        public int UpdateTutorRequest(TutorRequestClass tutorRequestClass)
        {
            return dal.UpdateTutorRequest(tutorRequestClass);
        }
        
        public DataTable SelectedForUpdateTutorRequest(TutorRequestClass requestClass)
        {
            return dal.SelectedForUpdateTutorRequest(requestClass);
        }

        public DataTable LoadCMBBuilding()
        {
            //string[] val = { "232"};
            //DataTable dt = dal.PopulateCmbBuilding();
            //dt.Rows.Add(val);
            //return dt;
            return dal.PopulateCmbBuilding();
        }

        public DataTable LoadCMBBuildingBlock()
        {
            return dal.PopulateCmbBuildingBlock();
        }
        public DataTable LoadCMBModels()
        {
            return dal.PopulateCmbModels();
        }
        

        public int AddDepartment(DepartmentClass department)
        {
            return dal.AddDepartment(department);
        }

        public int AddEquipment(EquipmentClass equipment)
        {
            return dal.AddEquipment(equipment);
        }

        public int AddEquipmentType(EquipmentTypeClass equipmentType)
        {
            return dal.AddEquipmentType(equipmentType);
        }

        public int AddInspection(InspectionClass inspection)
        {
            return dal.AddInspection(inspection);
        }

        public int AddInspectionDetail(InspectionDetailClass inspectionDetail)
        {
            return dal.AddInspectionDetail(inspectionDetail);
        }

        public int AddStaff(StaffClass staff)
        {
            return dal.AddStaff(staff);
        }

        public int UpdateStaff(StaffClass CLASS)
        {
            return dal.UpdateStaff(CLASS);
        }

        public DataTable SelectForUpdateStaff(StaffClass staffed)
        {
            return dal.SelectForUpdateStaff(staffed);
        }
        
        public int AddStudent(StudentClass student)
        {
            return dal.AddStudent(student);
        }

        public int AddTaskType(TaskTypeClass taskType)
        {
            return dal.AddTaskType(taskType);
        }

        public int AddRequest(RequestClass request)
        {
            return dal.AddRequest(request);
        }

        public int AddTutorRequest(TutorRequestClass tutorRequest)
        {
            return dal.AddTutorRequest(tutorRequest);
        }

        //public int AddUser(UsersClass user)
        //{
        //    return dal.AddUser(user);
        //}

        public DataTable GetLogin(LoginClass login)
        {
            return dal.GetLogin(login);
        }
    }
}
