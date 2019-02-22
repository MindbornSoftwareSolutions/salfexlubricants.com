using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slfexlubricants.com
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<object[]> cart = Session["cart"] as List<object[]>;
            if(cart==null)
            {
                cart = new List<object[]>();
                Session["cart"] = cart;
            }
            //label_cartitems.Text = "(" + cart.Count + ")";
        }
    }
}