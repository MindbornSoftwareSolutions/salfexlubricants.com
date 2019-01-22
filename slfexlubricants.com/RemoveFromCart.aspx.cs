using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slfexlubricants.com
{
    public partial class RemoveFromCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<object[]> cart = Session["cart"] as List<object[]>;
            if (cart == null)
            {
                cart = new List<object[]>();
                Session["cart"] = cart;
            }

            int index = Convert.ToInt32(Request["index"]);
            cart.RemoveAt(index);

            Response.Redirect("/Cart");
        }
    }
}