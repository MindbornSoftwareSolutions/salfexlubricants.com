using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using slfexlubricants.com;
using System.Data;

namespace Admin
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

				DataTable dt = DBManager.ExecuteQuery("select * from item where itemid="+ iid);
				if (dt.Rows.Count == 0)
				{
					Response.Redirect("/Admin/Login.aspx");
					return;
				}

				DataRow item = dt.Rows[0];
				int cid = Convert.ToInt32(item["categoryid"]);
				Cache["cid"] = cid;

                DataTable table = DBManager.ExecuteQuery("select * from category");
                dd_category.DataSource = table;
                dd_category.DataTextField = "name";
                dd_category.DataValueField = "categoryid";
                dd_category.SelectedValue = cid.ToString();
                dd_category.DataBind();

				tb_name.Text = Convert.ToString(item["name"]);
				tb_altname.Text = Convert.ToString(item["subname"]);
				tb_rates.Text = Convert.ToString(item["rate"]);
				tb_description.Text = Convert.ToString(item["descriptionjson"]);
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
			DBManager.ExecuteNonQuery("update item set categoryid=@cid, name=@name, subname=@altname, descriptionjson=@description, rate=@rates where itemid=@iid", "@cid", cid, "@name", name, "@altname", altname, "@description", description, "@rates", rates, "@iid",iid);


			if (FileUpload1.HasFile)
			{
				imageurl = Convert.ToString(iid)+".jpg";
				String imageurl2 = Server.MapPath("/Images/" + imageurl);
				FileUpload1.SaveAs(imageurl2);
				DBManager.ExecuteNonQuery("update item set imageurl=@imageurl where itemid=@iid", "@imageurl", imageurl, "@iid", iid);
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