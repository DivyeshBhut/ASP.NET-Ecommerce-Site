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
    public partial class manage_categories : System.Web.UI.Page
    {
        SqlConnection con;
        DataSet ds;
        AdminClass cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = new AdminClass();
            con = cs.getCon();
            fillgrid();
        }
        
        void fillgrid()
        {
            cs = new AdminClass();
            GridView1.DataSource = cs.getCategory();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="cmd_update")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                ViewState["id"] = id;
                Response.Redirect("update-category.aspx?id="+ViewState["id"]);

            }
            else
            {
                int id = Convert.ToInt32(e.CommandArgument);
                ViewState["id"] = id;
                cs = new AdminClass();
                cs.deleteCategory(this,ViewState["id"].ToString());
                fillgrid();
            }
        }
    }
}