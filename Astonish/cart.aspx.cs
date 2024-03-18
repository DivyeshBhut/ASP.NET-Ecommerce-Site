using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class cart : System.Web.UI.Page
    {
        string user_id;
        Class1 cs;
        DataSet ds;
        int numberOfCartItem=0;
        int subtotal;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUserLogin();
            fillDataList();
        }
        public void getNumberOfItemInCart()
        {
            cs = new Class1();
            ds = cs.selectUserCartItems(user_id);
            if (ds.Tables.Count > 0)
            {
                numberOfCartItem = ds.Tables[0].Rows.Count;
            }
            lblnumOfCartItems.Text = Convert.ToString(numberOfCartItem);
        }
       
        public void getSubtotal()
        {
            subtotal = cs.calculateSubtotal(user_id);
            lblSubtotal.Text = Convert.ToString(subtotal);
        }
        public void fillDataList()
        {
            cs = new Class1();
            ds = cs.selectUserCartItems(user_id);
            DataListCart.DataSource = ds;
            DataListCart.DataBind();
            getSubtotal();
            getNumberOfItemInCart();
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

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            cs = new Class1();
            string productIdsAndQuantities = cs.GetProductIdsAndQuantities(user_id);
            string subtotalString = lblSubtotal.Text;

            Response.Redirect("checkout.aspx?total=" + subtotalString + "&productIdsAndQuantities=" + productIdsAndQuantities + "");
        }

        protected void DataListCart_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "cmd_minus")
            {
                cs = new Class1();
                int cart_id = Convert.ToInt32(e.CommandArgument);
                cs.decrementQty(this, cart_id);
                fillDataList();
            }
            else if (e.CommandName == "cmd_plus")
            {
                cs = new Class1();
                int cart_id = Convert.ToInt32(e.CommandArgument);
                cs.incrementQty(this,cart_id);
                fillDataList();
            }
            else if (e.CommandName == "cmd_close")
            {
                cs = new Class1();
                int cart_id = Convert.ToInt32(e.CommandArgument);
                cs.removeFromCart(this, cart_id,user_id);
                fillDataList();
            }
        }
    }
}