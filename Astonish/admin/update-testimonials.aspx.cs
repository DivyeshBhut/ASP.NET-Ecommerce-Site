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
    public partial class update_testimonials : System.Web.UI.Page
    {
        DataSet ds;
        AdminClass cs;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
            if (!IsPostBack)
            {
                fillFields();
            }
        }
        void getcon()
        {
            cs = new AdminClass();
            cs.getCon();
        }       
        void fillFields()
        {
            if (Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                cs = new AdminClass();
                ds = cs.getOneTesimonial(id);
                testimonial_name.Text = (ds.Tables[0].Rows[0][1]).ToString();
                testimonial_data.Text = (ds.Tables[0].Rows[0][2]).ToString();
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            cs = new AdminClass();
            cs.updateTestimonial(Convert.ToInt32(Request.QueryString["id"]), testimonial_name.Text, testimonial_data.Text);
            Response.Write("<script>alert('Testimonial Updated Successfully');</script>");
            Response.Write("<script>window.location.href='manage-testimonials.aspx'</script>");
        }
    }
}