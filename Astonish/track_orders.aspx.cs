using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class track_orders : System.Web.UI.Page
    {
        Class1 cs;
        string user_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                cs = new Class1();
                user_id = Session["user_id"].ToString();
                GridViewTrackOrders.DataSource = cs.getUserOrders(user_id);
                GridViewTrackOrders.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please Login to track your orders..');", true);
                Response.Redirect("login_form.aspx");
            }
            
        }
    }
}