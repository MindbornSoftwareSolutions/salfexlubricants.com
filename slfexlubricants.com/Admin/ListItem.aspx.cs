using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OVSWeb.Code;

namespace OVSWeb.Admin
{
	public partial class ListItem : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				LoadItems();
				string cidstr = Request["cid"];
				if (cidstr == null)
				{
					Response.Redirect("/Login.aspx");
					return;
				}
				int cid = Convert.ToInt32(cidstr);
				String category = Convert.ToString(DBManager.ExecuteScalar("select name from category where cid=@cid", "@cid", cid));
				l_category.Text = category;
			}
		}

		private void LoadItems()
		{
			string cidstr = Request["cid"];
			if (cidstr == null)
			{
				Response.Redirect("/Login.aspx");
				return;
			}
			int cid = Convert.ToInt32(cidstr);
			DataTable dt = DBManager.ExecuteQuery("select * from item where cid=@cid and status=1", "@cid", cid);
			Repeater1.DataSource = dt.DefaultView;
			Repeater1.DataBind();
		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			string cidstr = Request["cid"];
			if (cidstr == null)
			{
				Response.Redirect("/Login.aspx");
				return;
			}
			int cid = Convert.ToInt32(cidstr);
			Response.Redirect("/Admin/AddItem.aspx?cid=" + cid);
		}

		protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
		{
			if (e.CommandName.Equals("EditItem"))
			{
				int iid = Convert.ToInt32(e.CommandArgument);
				Response.Redirect("/Admin/EditItem.aspx?iid=" + iid);
			}
			else if(e.CommandName.Equals("RemoveItem"))
			{
				int iid = Convert.ToInt32(e.CommandArgument);
				DBManager.ExecuteNonQuery("delete from item where iid=@iid", "@iid", iid);
				LoadItems();
			}
		}
	}
}