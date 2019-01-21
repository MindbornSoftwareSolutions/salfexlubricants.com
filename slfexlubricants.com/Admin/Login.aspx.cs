using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using OVSWeb.Code;

namespace OVSWeb
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void OnLogin(object sender, EventArgs e)
		{
			String username = this.username.Text.Trim();
			String password = this.password.Text;

			Dictionary<string, object> map = new Dictionary<string, object>();
			map["@username"] = username;
			map["@password"] = password;

			int count = Convert.ToInt32(DBManager.ExecuteScalar("select count(*) from admin where username=@username and password=@password", map));

			if (count == 0)
			{
				l_error.Text = "Invalid Username or Password";
			}
			else
			{
				FormsAuthentication.SetAuthCookie(username, false);

				FormsAuthenticationTicket ticket1 =
				   new FormsAuthenticationTicket(
						1,                                   // version
						username,   // get username  from the form
						DateTime.Now,                        // issue time is now
						DateTime.Now.AddMinutes(90),         // expires in 10 minutes
						false,      // cookie is not persistent
						"Admin"                             // role assignment is stored
					// in userData
						);
				HttpCookie cookie1 = new HttpCookie(
				  FormsAuthentication.FormsCookieName,
				  FormsAuthentication.Encrypt(ticket1));
				Response.Cookies.Add(cookie1);
				Response.Redirect("/Admin/AdminHome.aspx");
			}
		}
	}
}