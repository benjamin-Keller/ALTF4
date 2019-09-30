using DAL;
using System.Data;


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

        public int UpdateEquipmentType(EquipmentTypeClass equipmentType)
        {
            return dal.UpdateEquipmentType(equipmentType);
        }

        public DataTable SelectedForUpdateEquipmentType(EquipmentTypeClass EquipTypeCode)
        {
            return dal.SelectedForUpdateEquipmentType(EquipTypeCode);
        }

        public DataTable GetInspection()
        {
            return dal.GetInspection();
        }

        public int UpdateInspection(InspectionClass inspection)
        {
            return dal.UpdateInspection(inspection);
        }

        public DataTable SelectedForUpdateInspection(InspectionClass InspectionCode)
        {
            return dal.SelectedForUpdateInspection(InspectionCode);
        }

        public DataTable GetInspectionDetail()
        {
            return dal.GetInspectionDetail();
        }

        public int UpdateInspectionDetail(InspectionDetailClass inspectionDetail)
        {
            return dal.UpdateInspectionDetail(inspectionDetail);
        }

        public DataTable SelectedForUpdateInspectionDetail(InspectionDetailClass InspectionDetailCode)
        {
            return dal.SelectedForUpdateInspectionDetail(InspectionDetailCode);
        }

        public DataTable GetRequests()
        {
            return dal.GetRequests();
        }

        public int UpdateRequest(RequestClass request)
        {
            return dal.UpdateRequest(request);
        }

        public DataTable SelectedForUpdateRequest(RequestClass RequestCode)
        {
            return dal.SelectedForUpdateRequest(RequestCode);
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

        public DataTable SelectForUpdateStaffExUser(StaffClass staffed)
        {
            return dal.SelectForUpdateStaffExUser(staffed);
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

        public DataTable Report_DislayDepartmentByBuilding(DepartmentClass department)
        {
            return dal.DisplayDepartByBuilding(department);
        }

        public DataTable Report_DisplayEquipmentByEquipmentType(EquipmentClass equipment)
        {
            return dal.DisplayEquipmentByEquipmentType(equipment);
        }

        public DataTable Report_DisplayEquipmentByVenue(EquipmentClass equipment)
        {
            return dal.DisplayEquipmentByVenue(equipment);
        }

        public DataTable Report_DisplayInspectionByDate(InspectionClass inspection)
        {
            return dal.DisplayInspectionByDate(inspection);
        }

        public DataTable Report_DisplayInspectionByStaffCode(InspectionClass inspection)
        {
            return dal.DisplayInspectionByStaffCode(inspection);
        }

        public DataTable Report_DisplayInspectionByVenue(InspectionClass inspection)
        {
            return dal.DisplayInspectionByVenue(inspection);
        }

        public DataTable Report_DisplayRequestsByAssignedStaff(RequestClass request)
        {
            return dal.DisplayRequestsByAssignedStaff(request);
        }

        public DataTable Report_DisplayRequestsByDate(RequestClass request)
        {
            return dal.DisplayRequestsByDate(request);
        }

        public DataTable Report_DisplayRequestsByStaffCode(RequestClass request)
        {
            return dal.DisplayRequestsByStaffCode(request);
        }

        public DataTable Report_DisplayRequestsByStudentCode(RequestClass request)
        {
            return dal.DisplayRequestsByStudentCode(request);
        }

        public DataTable Report_DisplayRequestsByTaskType(RequestClass request)
        {
            return dal.DisplayRequestsByTaskType(request);
        }

        public DataTable Report_DisplayRequestsByTime(RequestClass request)
        {
            return dal.DisplayRequestsByTime(request);
        }

        public DataTable Report_DisplayRequestsByStatus(RequestClass request)
        {
            return dal.DisplayRequestsByStatus(request);
        }

        public DataTable Report_DisplayStaffByDepartment(StaffClass staff)
        {
            return dal.DisplayStaffByDepartment(staff);
        }

        public DataTable Report_DisplayStaffByStaffType(StaffClass staff)
        {
            return dal.DisplayStaffByStaffType(staff);
        }

        public DataTable Report_DisplayTutorRequestByRequestDate(TutorRequestClass tutorRequest)
        {
            return dal.DisplayTutorRequestByRequestDate(tutorRequest);
        }

        public DataTable Report_DisplayTutorRequestByRequestEndTime(TutorRequestClass tutorRequest)
        {
            return dal.DisplayTutorRequestByRequestEndTime(tutorRequest);
        }

        public DataTable Report_DisplayTutorRequestByRequestModuleCode(TutorRequestClass tutorRequest)
        {
            return dal.DisplayTutorRequestByRequestModuleCode(tutorRequest);
        }

        public DataTable Report_DisplayTutorRequestByRequestStartTime(TutorRequestClass tutorRequest)
        {
            return dal.DisplayTutorRequestByRequestStartTime(tutorRequest);
        }

        public DataTable Report_DisplayTutorRequestByRequestVenue(TutorRequestClass tutorRequest)
        {
            return dal.DisplayTutorRequestByRequestVenue(tutorRequest);
        }

        public DataTable Report_DisplayVenueByBuilding(VenueClass venue)
        {
            return dal.DisplayVenueByBuilding(venue);
        }

        public DataTable Report_DisplayVenueByBuildingBlock(VenueClass venue)
        {
            return dal.DisplayVenueByBuildingBlock(venue);
        }

        public DataTable Report_DisplayInspectionDetailsByEquip(InspectionDetailClass inspectionDetail)
        {
            return dal.DisplayInspectionDetailsByEquip(inspectionDetail);
        }

        public DataTable Report_DisplayInspectionDetailsByInspectCode(InspectionDetailClass inspectionDetail)
        {
            return dal.DisplayInspectionDetailsByInspectCode(inspectionDetail);
        }

        public DataTable Report_DisplayInspectionDetailsByStaffCode(InspectionDetailClass inspectionDetail)
        {
            return dal.DisplayInspectionDetailsByStaffCode(inspectionDetail);
        }

        public DataTable Report_DisplayInspectionDetailsByStatus(InspectionDetailClass inspectionDetail)
        {
            return dal.DisplayInspectionDetailsByStatus(inspectionDetail);
        }

        public DataTable Report_DisplayInspectionDetailsByVenue(InspectionClass inspection)
        {
            return dal.DisplayInspectionDetailsByVenue(inspection);
        }

        public DataTable Report_DisplayTutorRequestByStatus(TutorRequestClass tutorRequest)
        {
            return dal.DisplayTutorRequestByRequestStatus(tutorRequest);
        }

        public int DeleteEquip(EquipmentClass equipment)
        {
            return dal.DeleteEquipment(equipment);
        }

        public int DeleteVenue(VenueClass venue)
        {
            return dal.DeleteVenue(venue);
        }
        
    }
}
