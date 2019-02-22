using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slfexlubricants.com
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String itemid = Request["itemid"];
            product_image.ImageUrl = "/Images/" + itemid + ".jpg";
        }
    }
}