using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace Info_IT.Pages
{
    public partial class InspectionDetails : System.Web.UI.Page
    {
        BusinessLogicLayer bll = new BusinessLogicLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dgInspectionDetails_Load1(object sender, EventArgs e)
        {
            cmbEquipment.DataSource = bll.GetEquipment();

            cmbEquipment.DataTextField = "Equipment Description";
            cmbEquipment.DataValueField = "Equipment Code";
            cmbEquipment.DataBind();

            cmbStaffMember.DataSource = bll.GetStaff();

            cmbStaffMember.DataTextField = "First Name";
            cmbStaffMember.DataValueField = "Staff Code";
            cmbStaffMember.DataBind();

            cmbInspectionCode.DataSource = bll.GetInspection();

            cmbInspectionCode.DataTextField = "Inspection Code";
            cmbInspectionCode.DataValueField = "Inspection Code";

            cmbInspectionCode.DataBind();

            dgInspectionDetails.DataSource = bll.GetInspectionDetail();
            dgInspectionDetails.DataBind();
        }

        protected void dgInspectionDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DAL.InspectionDetailClass inspectionDetailClass = new DAL.InspectionDetailClass(int.Parse(dgInspectionDetails.SelectedItem.Cells[1].Text.ToString()));

                var values = bll.SelectedForUpdateInspectionDetail(inspectionDetailClass);

                txtFaultComment.Text = values.Rows[0].Table.Rows[0].ItemArray[4].ToString();

                cmbInspectionCode.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[1].ToString();
                cmbEquipment.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[2].ToString();
                cmbStaffMember.SelectedValue = values.Rows[0].Table.Rows[0].ItemArray[3].ToString();
                cmbStatus.Text = values.Rows[0].Table.Rows[0].ItemArray[5].ToString();
            }
            catch (Exception b)
            {

            }
        }

        protected void BtnManageUpdate(object sender, EventArgs e)
        {
            dgInspectionDetails.DataSource = bll.GetInspectionDetail();

            try
            {
                //Error for input string not found
                DAL.InspectionDetailClass inspection = new DAL.InspectionDetailClass(DAL.InspectionDetailClass.InspectionDetailCode, int.Parse(cmbInspectionCode.SelectedValue.ToString()), int.Parse(cmbEquipment.SelectedValue.ToString()), int.Parse(cmbStaffMember.SelectedValue.ToString()), txtFaultComment.Text, cmbStatus.Text.ToString());
                int x = bll.UpdateInspectionDetail(inspection);

                if (x > 0)
                {
                    txtFaultComment.Text = "";
                    cmbEquipment.Text = "";
                    cmbInspectionCode.Text = "";
                    cmbStaffMember.Text = "";
                    cmbStatus.Text = "";
                }
                else
                {
                }
            }
            catch
            {
            }

            dgInspectionDetails.DataSource = bll.GetInspectionDetail();
            dgInspectionDetails.DataBind();
        }

        protected void BtnManageAdd(object sender, EventArgs e)
        {
            try
            {
                //Error for input string not found
                DAL.InspectionDetailClass inspection = new DAL.InspectionDetailClass(int.Parse(cmbInspectionCode.SelectedValue.ToString()), int.Parse(cmbEquipment.SelectedValue.ToString()), int.Parse(cmbStaffMember.SelectedValue.ToString()), txtFaultComment.Text, cmbStatus.SelectedValue.ToString());
                int x = bll.AddInspectionDetail(inspection);

                if (x > 0)
                {
                    txtFaultComment.Text = "";
                    cmbEquipment.Text = "";
                    cmbInspectionCode.Text = "";
                    cmbStaffMember.Text = "";
                    cmbStatus.Text = "";
                }
                else
                {

                }
            }
            catch
            {

            }

            dgInspectionDetails.DataSource = bll.GetInspectionDetail();
            dgInspectionDetails.DataBind();
        }
    }
}