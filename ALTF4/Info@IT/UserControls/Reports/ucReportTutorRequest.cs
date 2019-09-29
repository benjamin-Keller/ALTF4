using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Info_IT.UserControls.Reports
{
	public partial class ucReportTutorRequest : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public ucReportTutorRequest()
		{
			InitializeComponent();
		}

		private void UcReportTutorRequest_Load(object sender, EventArgs e)
		{
            dgvTutorRequestReport.DataSource = bll.GetTutorRequest();
            
            cmbVenueCode.DataSource = bll.GetVenues();

            cmbVenueCode.DisplayMember = "VenueDescription";
            cmbVenueCode.ValueMember = "VenueCode";
            cmbVenueCode.Text = "";

            cmbModuleCode.DataSource = bll.LoadCMBModels();

            cmbModuleCode.DisplayMember = "ModuleDescription";
            cmbModuleCode.ValueMember = "ModuleCode";
            cmbModuleCode.Text = "";
        }

        private void cmbRequestCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateRequest_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass();
                tutor.Date = Convert.ToDateTime(dateRequest.Text);

                dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestDate(tutor);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbModuleCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass();
                tutor.ModuleCode = int.Parse(cmbModuleCode.SelectedValue.ToString());

                dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestModuleCode(tutor);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbVenueCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass();
                tutor.VenueCode = int.Parse(cmbVenueCode.SelectedValue.ToString());

                dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestVenue(tutor);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass();
                tutor.StartTime = cmbStartTime.SelectedItem.ToString();

                dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestStartTime(tutor);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.TutorRequestClass tutor = new DAL.TutorRequestClass();
                tutor.EndTime = cmbEndTime.SelectedItem.ToString();

                dgvTutorRequestReport.DataSource = bll.Report_DisplayTutorRequestByRequestEndTime(tutor);
            }
            catch (Exception b)
            {

            }
        }
    }
}
