using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using slfexlubricants.com;

namespace Admin
{
	public partial class CustomerList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				DataTable dt = DBManager.ExecuteQuery("select custid as ID, username as Username, name as Name, contact as Contact, email as Email, token as Token from customer order by name");
				GridView1.DataSource = dt.DefaultView;
				GridView1.DataBind();
			}
		}

		protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			DataTable dt = DBManager.ExecuteQuery("select custid as ID, username as Username, name as Name, contact as Contact, email as Email, token as Token from customer order by name");
			GridView1.DataSource = dt.DefaultView;
			GridView1.PageIndex = e.NewPageIndex;
			GridView1.DataBind();
		}
	}
}