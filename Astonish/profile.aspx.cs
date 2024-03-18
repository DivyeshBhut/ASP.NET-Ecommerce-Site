using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setUservalue();
        }
        public void setUservalue()
        {
            if (Session["user_id"] != null)
            {
                lblUserName.Text = Session["user_name"].ToString();
                lblUserNameMain.Text = Session["user_name"].ToString();
                lblUserNameProfile.Text = Session["user_name"].ToString();
                lblUserEmail.Text = Session["user_email"].ToString();
            }           
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("track_orders.aspx");
        }
    }
}