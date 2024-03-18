using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class Astonish : System.Web.UI.MasterPage
    {
        Class1 cs;
        string user_id;
        protected void Page_Load(object sender, EventArgs e)
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
        protected void imgCart_Click(object sender, ImageClickEventArgs e)
        {
            if (user_id != null)
            {
                cs = new Class1();
                if (cs.checkCartItem(user_id))
                {
                    Response.Redirect("cart.aspx");
                }
                else
                {
                    Response.Redirect("noCart.aspx");
                }
            }
            else
            {
                Response.Redirect("noCart.aspx");
            }
        }

        protected void imgWish_Click(object sender, ImageClickEventArgs e)
        {
            if (user_id != null)
            {
                cs = new Class1();
                if (cs.checkWishItem(user_id))
                {
                    Response.Redirect("wishlist.aspx");
                }
                else
                {
                    Response.Redirect("noWish.aspx");
                }
            }
            else
            {
                Response.Redirect("noWish.aspx");
            }
        }

        protected void imgProfile_Click(object sender, ImageClickEventArgs e)
        {
            if (user_id != null)
            {
                Response.Redirect("profile.aspx");
            }
            else
            {
                Response.Redirect("login_form.aspx");
            }
        }
    }
}