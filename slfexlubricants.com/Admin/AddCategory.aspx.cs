using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace slfexlubricants.com.Admin
{
    public partial class AddCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = tb_name.Text;
            long iid = DBManager.ExecuteInsert("insert into category values (@name,null)", "@name", name);
            ClearForm();
            Response.Write("<script>alert('Category Added');</script>");
        }

        private void ClearForm()
        {
            tb_name.Text = "";        
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Categories");
        }
    }
}