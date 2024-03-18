using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish.admin
{
    public partial class manage_orders : System.Web.UI.Page
    {
        SqlConnection con;
        DataSet ds;
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
            GridView1.DataSource = cs.getOrders();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmd_update")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                ViewState["id"] = id;
                Response.Redirect("update-order.aspx?id=" + ViewState["id"]);
            }
            else
            {
                int id = Convert.ToInt32(e.CommandArgument);
                ViewState["id"] = id;
                cs = new AdminClass();
                cs.deleteOrder(ViewState["id"].ToString());
                fillgrid();
                Response.Write("<script>alert('Order Deleted Successfully');</script>");
            }
        }
    }
}