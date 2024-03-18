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
    public partial class manage_product : System.Web.UI.Page
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
            ProductsGridView.DataSource = cs.getProduct();
            ProductsGridView.DataBind();
        }
        protected void ProductsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "cmd_update")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                ViewState["id"] = id;
                Response.Redirect("update-product.aspx?id=" + ViewState["id"]);

            }
            else
            {
                int id = Convert.ToInt32(e.CommandArgument);
                ViewState["id"] = id;
                cs = new AdminClass();
                cs.deleteProduct(ViewState["id"].ToString());
                fillgrid();
                Response.Write("<script>alert('Product Deleted Successfully');</script>");
            }
        }
    }
}