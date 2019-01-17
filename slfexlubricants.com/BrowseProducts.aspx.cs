using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slfexlubricants.com
{
    public partial class BrowseProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataTable table = DBManager.ExecuteQuery("select * from [item]");
                Repeater_ItemList.DataSource = table.DefaultView;
                Repeater_ItemList.DataBind();
            }
        }
    }
}