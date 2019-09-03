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

        public DataTable GetDepartment()
        {
            return dal.GetDepartment();
        }

        public DataTable GetEquipment()
        {
            return dal.GetEquipment();
        }

        public DataTable GetEquipmentType()
        {
            return dal.GetEquipmentType();
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

        public DataTable GetTasktype()
        {
            return dal.GetTasktype();
        }

        public DataTable GetTutorRequest()
        {
            return dal.GetTutorRequest();
        }
    }
}
