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
    public partial class product_details : System.Web.UI.Page
    {
        Class1 cs;
        SqlConnection con;
        string productId;
        int c_id;
        DataSet ds;
        string user_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ProductId"] != null)
            {
                productId = Request.QueryString["ProductId"];
            }

            setProductDetails();
            setDataListSimilarProducts();
            checkUserLogin();
        }
        public void checkUserLogin()
        {
            if (Session["user_id"] != null)
            {
                user_id = Session["user_id"].ToString();
            }
            else
            {
                user_id = null;
            }
        }
        public void setProductDetails()
        {
            cs = new Class1();
            ds = cs.setProductDetails(productId);
            lblProductName.Text = (ds.Tables[0].Rows[0][1]).ToString();
            lblProductDesc.Text = (ds.Tables[0].Rows[0][5]).ToString();
            lblProductMrp.Text = (ds.Tables[0].Rows[0][3]).ToString();
            lblProductPrice.Text = (ds.Tables[0].Rows[0][4]).ToString();
            imgProductImage.Attributes["src"] = (ds.Tables[0].Rows[0][2]).ToString();
            c_id = Convert.ToInt32((ds.Tables[0].Rows[0][6]).ToString());

        }
        public void setDataListSimilarProducts()
        {
            cs = new Class1();
            ds = cs.getCategoryProducts(c_id);

            DataListSimilarProducts.DataSource = ds;
            DataListSimilarProducts.DataBind();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (user_id != null)
            {
                int qty = Convert.ToInt32(txtQty.Text);
                cs = new Class1();
                cs.addToCart(this,productId,user_id,qty);
            }
            else
            {
                Response.Redirect("login_form.aspx");
            }
        }

        protected void btnAddToWish_Click(object sender, EventArgs e)
        {
            if (user_id != null)
            {
                cs = new Class1();
                cs.addToWish(this, productId, user_id);
            }
            else
            {
                Response.Redirect("login_form.aspx");
            }
        }

        protected void btnViewMoreProductDetails_Click(object sender, EventArgs e)
        {

        }
    }
}