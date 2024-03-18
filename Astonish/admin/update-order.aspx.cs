using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish.admin
{
    public partial class update_order : System.Web.UI.Page
    {
        DataSet ds;
        AdminClass cs;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
        }
        void getcon()
        {
            cs = new AdminClass();
            cs.getCon();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            cs = new AdminClass();
            cs.updateOrder(Convert.ToInt32(Request.QueryString["id"]),ddlOrderStatus.SelectedValue);
            Response.Write("<script>alert('Order Status Updated Successfully');</script>");
            Response.Write("<script>window.location.href='manage-orders.aspx'</script>");
        }
    }
}