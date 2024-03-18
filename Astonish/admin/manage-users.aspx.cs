using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish.admin
{
    public partial class manage_users : System.Web.UI.Page
    {
        SqlConnection con;
        AdminClass cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
            fillgrid();
        }
        void getcon()
        {
            cs = new AdminClass();
            con = cs.getCon();
        }
        void fillgrid()
        {
            cs = new AdminClass();
            GridView1.DataSource = cs.getusers();
            GridView1.DataBind();
        }       
    }
}