using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Astonish.admin;

namespace Astonish.admin
{
    public partial class add_category : System.Web.UI.Page
    {
        AdminClass cs;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = new AdminClass();
            con = cs.getCon();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(c_name.Text))
            {
                cs = new AdminClass();
                cs.addCategory(this, c_name.Text);
                Response.Write("<script>alert('Category added successfully');</script>");
                c_name.Text = "";
            }
            else
            {
                Response.Write("<script>alert('Please fill all the required fields');</script>");
            }
        }
    }
}