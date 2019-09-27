﻿using System;
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
	public partial class ucReportRequest : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public ucReportRequest()
		{
			InitializeComponent();
		}

		private void UcReportRequest_Load(object sender, EventArgs e)
		{
            dateRequest.Value = DateTime.Now;

            dgvRequestReport.DataSource = bll.GetRequests();

            cmbTaskTypeCode.DataSource = bll.GetTasktype();

            cmbTaskTypeCode.DisplayMember = "TaskName";
            cmbTaskTypeCode.ValueMember = "taskTypeCode";

            cmbAssignedStaffCode.DataSource = bll.GetStaff();

            cmbAssignedStaffCode.DisplayMember = "FirstName";
            cmbAssignedStaffCode.ValueMember = "StaffCode";

            cmbStaffCode.DataSource = bll.GetStaff();

            cmbStaffCode.DisplayMember = "FirstName";
            cmbStaffCode.ValueMember = "StaffCode";

            cmbStudentCode.DataSource = bll.GetStudent();

            cmbStudentCode.DisplayMember = "FirstName";
            cmbStudentCode.ValueMember = "StudentCode";

        }

        private void cmbStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestStaffCode = int.Parse(cmbStaffCode.SelectedValue.ToString());

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByStaffCode(request);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbStudentCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestStudentCode = int.Parse(cmbStudentCode.SelectedValue.ToString());

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByStudentCode(request);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbTaskTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestTaskTypeCode = int.Parse(cmbTaskTypeCode.SelectedValue.ToString());

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByTaskType(request);
            }
            catch (Exception b)
            {

            }
        }

        private void dateRequest_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestDate = Convert.ToDateTime(dateRequest.Text);

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByDate(request);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestTime = cmbTime.SelectedItem.ToString();

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByTime(request);
            }
            catch (Exception b)
            {

            }
        }

        private void cmbAssignedStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.RequestClass request = new DAL.RequestClass();
                request.RequestAssignedStaffCode = int.Parse(cmbAssignedStaffCode.SelectedValue.ToString());

                dgvRequestReport.DataSource = bll.Report_DisplayRequestsByAssignedStaff(request);
            }
            catch (Exception b)
            {

            }
        }
    }
}
