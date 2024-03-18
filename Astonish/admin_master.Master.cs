using Astonish.admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class admin_master : System.Web.UI.MasterPage
    {
        SqlConnection con;
        DataSet ds;
        AdminClass cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user_id"] != null)
                {
                    lbluser.Text = Session["user_name"].ToString();
                    cs = new AdminClass();
                    setNumbersToLabels();
                }
                else
                {
                    Response.Redirect("../login_form.aspx");
                }
            }
        }
        public void getCon()
        {
            cs = new AdminClass();
            con = cs.getCon();
        }
        public void setNumbersToLabels()
        {
            cs = new AdminClass();

            int productCount = cs.getProductCount();
            if (lblNumberProducts != null)
            {
                lblNumberProducts.Text = productCount.ToString();
            }

            int testimonialCount = cs.getTestimonialCount();
            if (lblNumberTestimonial != null)
            {
                lblNumberTestimonial.Text = testimonialCount.ToString();
            }

            int userCount = cs.getUserCount();
            if (lblNumberUsers != null)
            {
                lblNumberUsers.Text = userCount.ToString();
            }

            int categoryCount = cs.getCategoryCount();
            if (lblNumberCategory != null)
            {
                lblNumberCategory.Text = categoryCount.ToString();
            }
            int orderCount = cs.getOrderCount();
            if (lblNumberCategory != null)
            {
                lblNumberOrders.Text = orderCount.ToString();
            }
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("../login_form.aspx");
        }
    }
}