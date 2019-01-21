using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using slfexlubricants.com;

namespace Admin
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
			String subname = tb_altname.Text;
			String description = tb_description.Text;
			String rates = tb_rates.Text;
			String imageurl = "";

//			long iid=DBManager.ExecuteInsert("insert into item values (@cid,@name,@altname,@description,@imageurl,@rates,1)", "@cid", cid, "@name", name, "@altname", altname, "@description", description, "@imageurl", imageurl,"@rates",rates);
            long iid=DBManager.ExecuteInsert("insert into item values (@cid,@name,@subname,@description,@rate,'')","@cid",cid,"@name",name,"@subname",subname,"@description",description,"@rate",rates);

			if (FileUpload1.HasFile)
			{
				imageurl = Convert.ToString(iid)+".jpg";
				String imageurl2 = Server.MapPath("/Images/" + imageurl);
				FileUpload1.SaveAs(imageurl2);
				DBManager.ExecuteNonQuery("update item set imageurl=@imageurl where itemid=@iid", "@imageurl", imageurl, "@iid", iid);
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