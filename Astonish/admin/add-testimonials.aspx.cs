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
    public partial class add_testimonials : System.Web.UI.Page
    {
        AdminClass cs;
        SqlConnection con;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
        }
        void getcon()
        {
            cs = new AdminClass();
            con = cs.getCon();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            ds = cs.getCategory();
            cs = new AdminClass();
            cs.addTestimonial(testimonial_name.Text, testimonial_data.Text);
            clearFields();
            Response.Write("<script>alert('Testimonial added successfully');</script>");
        }

        private void clearFields()
        {
            testimonial_name.Text = "";
            testimonial_data.Text = "";
        }
    }
}