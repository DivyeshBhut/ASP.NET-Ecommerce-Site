using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class index : System.Web.UI.Page
    {
        Class1 cs;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getDatalistFeatureProducts();
                setUserNameHeroSec();
                getDataListTestimonailData();
            }
        }
        public void getDataListTestimonailData()
        {
            cs = new Class1();
            ds = cs.getTestimonails();
            DataListTestimonail.DataSource = ds;
            DataListTestimonail.DataBind();
        }
        public void setUserNameHeroSec()
        {
            if (Session["user_name"] != null)
            {
                lblUserNameHeroSec.Text = Session["user_name"].ToString();
            }
        }
        public void getDatalistFeatureProducts()
        {
            cs = new Class1();
            ds = cs.getDataFeatureProducts();
            datalistFeatureProducts.DataSource = ds;
            datalistFeatureProducts.DataBind();
        }

        protected void linkbtnShopNow_Click(object sender, EventArgs e)
        {
            Response.Redirect("all_products.aspx");
        }

        protected void linkbtnFeatureProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("all_products.aspx");
        }

        protected void linkbtnAboutUsIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("about_us.aspx");
        }

        protected void linkbtnHappyClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("all_products.aspx");
        }


        protected void linkbtnContactUsIndex_Click(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx");
        }
    }
}