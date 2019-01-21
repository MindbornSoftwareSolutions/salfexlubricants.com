using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using slfexlubricants.com;
using System.Data;
using System.Text;

namespace Admin
{
	public partial class UpdateRates : System.Web.UI.Page
	{
		private static char[] separators1 = new char[] { '\n', '\r' };
		private static char[] separators2 = new char[] { '=' };

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				LoadItems();
			}
		}

		public void LoadItems()
		{
			DataTable dt = DBManager.ExecuteQuery("select * from item where status>0 order by name");
			repeater1.DataSource = dt;
			repeater1.DataBind();
		}

		protected void Unnamed1_Click(object sender, EventArgs e)
		{
			foreach (String s in Request.Form.AllKeys)
			{
				if (s.StartsWith("ta_"))
				{
					int iid = Convert.ToInt32(s.Substring(3));
					String rates = Request.Form[s];

					bool instock = null!=Request.Form["is_" + iid];

					StringBuilder sb = new StringBuilder();
					String[] tokens = rates.Split(separators1);
					foreach (String token in tokens)
					{
						String t = token.Trim();
						if (t.Length == 0) continue;
						String[] tokens2 = token.Split(separators2);
						//sb.Append(tokens2[0].Trim()).Append('=').Append(tokens2[1]).Append('\n');
						for (int i = 0; i < tokens2.Length; i++)
						{
							if (i > 0) sb.Append("=");
							sb.Append(tokens2[i].Trim());
						}
						sb.Append("\n");
					}

					rates = sb.ToString();

					DBManager.ExecuteNonQuery("update item set rates=@rates,status=@status where iid=@iid", "@rates", rates,"@status",instock?1:2 ,"@iid", iid);
				}
			}
			Response.Redirect("/Admin/Categories.aspx");
		}
	}
}