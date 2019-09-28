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

namespace Info_IT.UserControls
{
	public partial class ucReportStudent : UserControl
	{
        BusinessLogicLayer bll = new BusinessLogicLayer();

        public ucReportStudent()
		{
			InitializeComponent();
		}

		private void UcReportStudent_Load(object sender, EventArgs e)
		{
            dgvStudentReport.DataSource = bll.GetStudent();
        }
	}
}