using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using slfexlubricants.com;

namespace Admin
{
	public partial class ChangePassword : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Unnamed1_Click(object sender, EventArgs e)
		{
			String current = tb_currentpassword.Text.Replace("'","''");
            String np = tb_newpassword.Text.Replace("'", "''");
            String cp = tb_confirmpassword.Text.Replace("'", "''");

			if (np != cp)
			{
				message.Text = "Passwords mismatch";
				message.CssClass = "alert alert-danger";
				return;
			}

			int res = DBManager.ExecuteNonQuery("update admin set password='"+np+"' where username='admin' and password='"+cp+"'");
			if (res == 0)
			{
				message.Text = "Incorrect password";
				message.CssClass = "alert alert-danger";
				return;
			}
			else
			{
				message.Text = "Password Changed Successfully";
				message.CssClass = "alert alert-success";
				return;
			}
		}
	}
}