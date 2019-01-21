using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slfexlubricants.com
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Request["id"]);
                List<object[]> cart = Session["cart"] as List<object[]>;
                if (cart == null)
                {
                    cart = new List<object[]>();
                    Session["cart"] = cart;
                }
                DataTable item = DBManager.ExecuteQuery("select * from item where itemid=" + id);
                DataRow row = item.Rows[0];
                cart.Add(new Object[] { row["itemid"], row["name"], row["subname"],row["descriptionjson"],1 });

                Response.Write("<script>alert('Item Added to Cart');</script>");

            }
            catch(Exception)
            {

            }
            Response.Redirect("BrowseProducts");
        }
    }
}