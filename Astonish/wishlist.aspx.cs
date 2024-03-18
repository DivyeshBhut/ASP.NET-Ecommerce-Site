using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class wishlist : System.Web.UI.Page
    {
        string user_id;
        Class1 cs;
        DataSet ds;
        int numberOfWishItem = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            checkUserLogin();
            fillDataList();
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
        public void fillDataList()
        {
            cs = new Class1();
            ds = cs.selectUserWishItems(user_id);
            DataListWish.DataSource = ds;
            DataListWish.DataBind();
            getNumberOfItemInCart();
        }
        public void getNumberOfItemInCart()
        {
            cs = new Class1();
            ds = cs.selectUserWishItems(user_id);
            if (ds.Tables.Count > 0)
            {
                numberOfWishItem = ds.Tables[0].Rows.Count;
            }
            lblnumOfWishItems.Text = Convert.ToString(numberOfWishItem);
        }
        protected void DataListCart_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "cmd_close")
            {
                cs = new Class1();
                int cart_id = Convert.ToInt32(e.CommandArgument);
                cs.removeFromWish(this, cart_id, user_id);
                fillDataList();
            }
        }
    }
}