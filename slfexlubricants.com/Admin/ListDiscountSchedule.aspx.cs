using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using OVSWeb.Code;
using System.Globalization;

namespace OVSWeb.Admin
{
	public partial class ListDiscountSchedule : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				LoadDiscountSchedule();
			}
		}

		private void LoadDiscountSchedule()
		{
			DataTable table = DBManager.ExecuteQuery("select * from discountschedule order by startdate");
			GridViewDiscountSchedule.DataSource = table.DefaultView;
			GridViewDiscountSchedule.DataBind();
		}

		protected void OnAddSchedule(object sender, EventArgs e)
		{
			try
			{
				DateTime sd = DateTime.ParseExact(startdate.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
				DateTime ed = DateTime.ParseExact(enddate.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
				String t = title.Text;
				int d = Convert.ToInt32(discount.Text);
				DBManager.ExecuteNonQuery("insert into discountschedule values (@startdate,@enddate,@title,@discount)", "@startdate", sd, "@enddate", ed, "@title", t, "@discount", d);

				LoadDiscountSchedule();
			}
			catch (Exception ex)
			{

			}
		}

		protected void GridViewDiscountSchedule_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Remove")
			{
				int id = Convert.ToInt32(e.CommandArgument);

				DBManager.ExecuteNonQuery("delete from discountschedule where sid=@sid", "@sid", id);
				LoadDiscountSchedule();
			}
		}
	}
}