using slfexlubricants.com;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Admin
{
	public partial class Categories : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if(!IsPostBack)
            {
                DataTable table = DBManager.ExecuteQuery("select * from category");
                repeater_cat.DataSource = table;
                repeater_cat.DataBind();
            }
		}
	}
}