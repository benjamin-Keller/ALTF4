using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Info_IT.Pages
{
	public partial class Equipment : System.Web.UI.Page
	{
		BusinessLogicLayer bll = new BusinessLogicLayer();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void dgEquipment_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void dgEquipment_Load1(object sender, EventArgs e)
		{
			dgEquipment.DataSource = bll.GetEquipment();
			dgEquipment.DataBind();
		}
	}
}