using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OVSWeb.Code;
using System.Data;

namespace OVSWeb.Admin
{
	public partial class EditItem : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string iidstr = Request["iid"];
				if (iidstr == null)
				{
					Response.Redirect("/Admin/Login.aspx");
					return;
				}
				int iid = Convert.ToInt32(iidstr);

				DataTable dt = DBManager.ExecuteQuery("select * from item where iid=@iid", "@iid", iid);
				if (dt.Rows.Count == 0)
				{
					Response.Redirect("/Admin/Login.aspx");
					return;
				}

				DataRow item = dt.Rows[0];
				int cid = Convert.ToInt32(item["cid"]);
				Cache["cid"] = cid;
				dd_category.SelectedIndex = cid - 1;
				tb_name.Text = Convert.ToString(item["name"]);
				tb_altname.Text = Convert.ToString(item["altname"]);
				tb_rates.Text = Convert.ToString(item["rates"]);
				tb_description.Text = Convert.ToString(item["description"]);
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string iidstr = Request["iid"];
			if (iidstr == null)
			{
				Response.Redirect("/Admin/Login.aspx");
				return;
			}
			int iid = Convert.ToInt32(iidstr);
			int cid = dd_category.SelectedIndex+1;
			String name = tb_name.Text;
			String altname = tb_altname.Text;
			String description = tb_description.Text;
			String rates = tb_rates.Text;
			String imageurl = "";



			//long iid=DBManager.ExecuteInsert("insert into item values (@cid,@name,@altname,@description,@imageurl,@rates,1)", "@cid", cid, "@name", name, "@altname", altname, "@description", description, "@imageurl", imageurl,"@rates",rates);
			DBManager.ExecuteNonQuery("update item set cid=@cid, name=@name, altname=@altname, description=@description, rates=@rates where iid=@iid", "@cid", cid, "@name", name, "@altname", altname, "@description", description, "@rates", rates, "@iid",iid);


			if (FileUpload1.HasFile)
			{
				imageurl = Convert.ToString(iid);
				String imageurl2 = Server.MapPath("/Images/Items/" + imageurl);
				FileUpload1.SaveAs(imageurl2);
				DBManager.ExecuteNonQuery("update item set imageurl=@imageurl where iid=@iid", "@imageurl", imageurl, "@iid", iid);
			}
			Response.Redirect("/Admin/ListItem.aspx?cid=" + Cache["cid"]);
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("/Admin/ListItem.aspx?cid=" + Cache["cid"]);
		}

		private void ClearForm()
		{
			tb_name.Text = "";
			tb_altname.Text = "";
			tb_description.Text = "";
		}

	}
}