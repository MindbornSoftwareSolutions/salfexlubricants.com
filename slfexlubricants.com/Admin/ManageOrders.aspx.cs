using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using slfexlubricants.com;

namespace Admin
{
	public partial class ManageOrders : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				LoadOrders();
			}
		}

		private void LoadOrders()
		{
			String status = dd_orderstatus.Text;
			DataTable table = DBManager.ExecuteQuery("select * from orders,customer where orders.custid=customer.custid and orders.status="+status+"' order by datetime desc");
			//Repeater1.DataSource = table;
			//Repeater1.DataBind();

			GridView1.DataSource = table.DefaultView;
			GridView1.DataBind();
		}

		protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			int rowIndex = Convert.ToInt32(e.CommandArgument);
			int id = Convert.ToInt32(GridView1.DataKeys[rowIndex].Values[0]);
			int custid = Convert.ToInt32(DBManager.ExecuteScalar("select custid from orders where oid="+ id));
			String contact=Convert.ToString(DBManager.ExecuteScalar("select contact from customer where custid="+custid));

			switch (e.CommandName)
			{
				case "Accept":
					DBManager.ExecuteNonQuery("update orders set status='Accepted' where oid="+ id);
					//Util.SendSMS(contact,"Your order no "+id+" is Accepted");
					break;
				case "Dispatch":
					DBManager.ExecuteNonQuery("update orders set status='Dispatched' where oid="+ id);
					//Util.SendSMS(contact,"Your order no "+id+" is Dispatched");
					break;
				case "Delivered":
					DBManager.ExecuteNonQuery("update orders set status='Delivered' where oid="+ id);
					//Util.SendSMS(contact,"Your order no "+id+" is Delivered");
					break;
				case "Reject":
					DBManager.ExecuteNonQuery("update orders set status='Rejected' where oid="+ id);
					//Util.SendSMS(contact,"Your order no "+id+" is Rejected. Contact customer care.");
					break;
				case "Remove":
					DBManager.ExecuteNonQuery("delete from orders where oid="+ id);
					break;
			}
			LoadOrders();
		}

		protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadOrders();
		}

		protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			GridView1.PageIndex = e.NewPageIndex;
			LoadOrders();
		}
	}
}