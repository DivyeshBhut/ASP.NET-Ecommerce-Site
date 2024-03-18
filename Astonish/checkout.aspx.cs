using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class checkout : System.Web.UI.Page
    {
        Class1 cs;
        int user_id;
        int totalAmt;
        string productIdsAndQuantities;
        string title;
        string nm;
        string eml;
        string mnum;
        string ad1;
        string ad2;
        string cty;
        string ste;
        string zipcode;
        string coun;
        string pay;
        string status = "Update status soon";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                user_id = Convert.ToInt32(Session["user_id"].ToString());
                totalAmt = Convert.ToInt32(Request.QueryString["total"]);
                productIdsAndQuantities = Request.QueryString["productIdsAndQuantities"];
                lblSubtotal.Text = Request.QueryString["total"];
                lblTotal.Text = Request.QueryString["total"];
            }
        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                title = pre_name.SelectedValue;
                nm = name.Text;
                eml = email.Text;
                mnum = mno.Text;
                ad1 = address1.Text;
                ad2 = address2.Text;
                cty = city.Text;
                ste = state.Text;
                zipcode = zip.Text;
                coun = country.SelectedValue;
                pay = payment.SelectedValue;

                if (chkAgree.Checked)
                {
                    if (totalAmt!=0 && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(nm) && !string.IsNullOrEmpty(eml)
                        && !string.IsNullOrEmpty(mnum) && !string.IsNullOrEmpty(ad1) && !string.IsNullOrEmpty(ad2)
                        && !string.IsNullOrEmpty(cty) && !string.IsNullOrEmpty(ste) && !string.IsNullOrEmpty(zipcode)
                        && !string.IsNullOrEmpty(coun) && !string.IsNullOrEmpty(pay))
                    {
                        cs = new Class1();
                        cs.insertorder(user_id, totalAmt, productIdsAndQuantities, title, nm, eml, mnum, ad1, ad2, cty, ste, zipcode, coun, pay,status);
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Order successfully placed - Track Order Now');window.location='index.aspx';", true);
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please fill all the required fields');", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please agree Terms & Condition');", true);
                }
            }
            else
            {
                Response.Redirect("login_form.aspx");
            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx");
        }
    }
}