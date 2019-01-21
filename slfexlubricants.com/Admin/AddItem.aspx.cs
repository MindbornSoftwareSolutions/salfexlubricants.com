using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OVSWeb.Code;

namespace OVSWeb.Admin
{
	public partial class AddItem : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string cidstr = Request["cid"];
			if (cidstr == null)
			{
				Response.Redirect("/Login.aspx");
				return;
			}
			int cid = Convert.ToInt32(cidstr);
			String name = tb_name.Text;
			String altname = tb_altname.Text;
			String description = tb_description.Text;
			String rates = tb_rates.Text;
			String imageurl = "";

			long iid=DBManager.ExecuteInsert("insert into item values (@cid,@name,@altname,@description,@imageurl,@rates,1)", "@cid", cid, "@name", name, "@altname", altname, "@description", description, "@imageurl", imageurl,"@rates",rates);

			if (FileUpload1.HasFile)
			{
				imageurl = Convert.ToString(iid);
				String imageurl2 = Server.MapPath("/Images/Items/" + imageurl);
				FileUpload1.SaveAs(imageurl2);
				DBManager.ExecuteNonQuery("update item set imageurl=@imageurl where iid=@iid", "@imageurl", imageurl, "@iid", iid);
			}
			ClearForm();
			Response.Write("<script>alert('Item Added');</script>");
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			string cidstr = Request["cid"];
			if (cidstr == null)
			{
				Response.Redirect("/Login.aspx");
				return;
			}
			int cid = Convert.ToInt32(cidstr);
			Response.Redirect("/Admin/ListItem.aspx?cid=" + cid);
		}

		private void ClearForm()
		{
			tb_name.Text = "";
			tb_altname.Text = "";
			tb_description.Text = "";
		}

	}
}