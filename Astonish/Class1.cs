using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace Astonish
{
    public class Class1
    {
        SqlDataAdapter da;
        SqlConnection con;
        DataSet ds;
        SqlCommand cmd;

        public SqlConnection getCon()
        {
            string s = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            con = new SqlConnection(s);
            con.Open();
            return con;
        }
        public void registerNewUser(Page page, string name, string email, string password, string user_type)
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from user_tbl where email='" + email + "' and password='" + password + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('User Already Registered');", true);
            }
            else
            {
                cmd = new SqlCommand("insert into user_tbl (name,email,password,user_type) values ('" + name + "','" + email + "','" + password + "','" + user_type + "')", con);
                cmd.ExecuteNonQuery();
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('Register Successfully...');", true);
            }
            con.Close();
        }
        public void loginUser(Page page, string email, string password)
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from user_tbl where email = '" + email + "' and password = '" + password + "'", con);
            ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string userType = (ds.Tables[0].Rows[0][4]).ToString();
                string user_id = (ds.Tables[0].Rows[0][0]).ToString();
                string user_name = (ds.Tables[0].Rows[0][1]).ToString();
                string user_email = (ds.Tables[0].Rows[0][2]).ToString();

                if (userType == "Admin")
                {
                    page.Session["user_name"] = user_name;
                    page.Session["user_id"] = user_id;
                    page.Session["user_email"] = user_email;
                    page.Response.Redirect("admin/dashboard.aspx");
                }
                else if (userType == "User")
                {
                    page.Session["user_name"] = user_name;
                    page.Session["user_id"] = user_id;
                    page.Session["user_email"] = user_email;
                    page.Response.Redirect("index.aspx");
                }
            }
            else
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('Invalid Credentials!');", true);
            }
            con.Close();
        }
        public DataSet getDataFeatureProducts()
        {
            con = getCon();
            da = new SqlDataAdapter("select top 3 * from product_tbl ORDER BY NEWID()", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet getAllProducts()
        {
            con = getCon();
            da = new SqlDataAdapter("select * FROM product_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet getCategoryProducts(int c_id)
        {
            con = getCon();
            da = new SqlDataAdapter("select * from product_tbl where c_id='" + c_id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public Boolean checkCartItem(string user_id)
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from cart_tbl where user_id ='" + user_id + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public Boolean checkWishItem(string user_id)
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from wishlist_tbl where user_id ='" + user_id + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public DataSet getUserOrders(string user_id)
        {
            con = getCon();
            da = new SqlDataAdapter("select * from order_tbl where user_id='" + user_id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        
        public DataSet setProductDetails(string p_id)
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from product_tbl where p_id='" + p_id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void addToCart(Page page, string p_id, string u_id, int qty)
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from cart_tbl where user_id ='" + u_id + "' and p_id='" + p_id + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('already added to cart!');", true);
            }
            else
            {
                ds = new DataSet();
                da = new SqlDataAdapter("select * from product_tbl where p_id='" + p_id + "'", con);
                ds = new DataSet();
                da.Fill(ds);

                string p_name = (ds.Tables[0].Rows[0][1]).ToString();
                string p_img = (ds.Tables[0].Rows[0][2]).ToString();
                string p_price = (ds.Tables[0].Rows[0][4]).ToString();
                string p_desc = (ds.Tables[0].Rows[0][5]).ToString();

                cmd = new SqlCommand("insert into cart_tbl (user_id,p_id,p_name,p_img,qty,p_price,p_desc) " +
                "values ('" + Convert.ToInt32(u_id) + "','" + Convert.ToInt32(p_id) + "','" + p_name + "','" + p_img + "','" + qty + "','" + Convert.ToInt32(p_price) + "','" + p_desc + "')", con);
                cmd.ExecuteNonQuery();

                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('product added to cart.');", true);
            }
            con.Close();
        }

        public void addToWish(Page page, string p_id, string u_id)
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from wishlist_tbl where user_id ='" + u_id + "' and p_id='" + p_id + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('already added to wishlist!');", true);
            }
            else
            {
                ds = new DataSet();
                da = new SqlDataAdapter("select * from product_tbl where p_id='" + p_id + "'", con);
                ds = new DataSet();
                da.Fill(ds);

                string p_name = (ds.Tables[0].Rows[0][1]).ToString();
                string p_img = (ds.Tables[0].Rows[0][2]).ToString();
                string p_price = (ds.Tables[0].Rows[0][4]).ToString();
                string p_desc = (ds.Tables[0].Rows[0][5]).ToString();
                int qty = 1;

                cmd = new SqlCommand("insert into wishlist_tbl (user_id,p_id,p_name,p_img,qty,p_price,p_desc) " +
                "values ('" + Convert.ToInt32(u_id) + "','" + Convert.ToInt32(p_id) + "','" + p_name + "','" + p_img + "','" + qty + "','" + Convert.ToInt32(p_price) + "','" + p_desc + "')", con);
                cmd.ExecuteNonQuery();

                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('product added to Favourites.');", true);
            }
            con.Close();
        }
        public DataSet selectUserCartItems(string u_id)
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from cart_tbl where user_id='" + u_id + "'", con);
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void incrementQty(Page page,int cart_id)
        {
            con = getCon();
            cmd = new SqlCommand("select qty from cart_tbl where cart_id = '"+cart_id+"'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i < 10)
            {
                int newQty = i + 1;
                cmd = new SqlCommand("update cart_tbl set qty = '"+newQty+"' where cart_id = '"+cart_id+"'", con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('Maximum quantity reached!');", true);
            }
            con.Close();
        }
        public void decrementQty(Page page, int cart_id)
        {
            con = getCon();
            cmd = new SqlCommand("select qty from cart_tbl where cart_id = '" + cart_id + "'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i>1)
            {
                int newQty = i - 1;
                cmd = new SqlCommand("update cart_tbl set qty = '" + newQty + "' where cart_id = '" + cart_id + "'", con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('Minimum quantity reached!');", true);
            }
            con.Close();
        }
        public void removeFromCart(Page page, int cart_id,string user_id)
        {
            con = getCon();
            cmd = new SqlCommand("delete from cart_tbl where cart_id = '"+cart_id+"'", con);
            cmd.ExecuteNonQuery();
            page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('Item Removed from cart.');", true);
            if (!checkCartItem(user_id))
            {
                page.Response.Redirect("noCart.aspx");
            }
            con.Close();
        }
        public int calculateSubtotal(string user_id)
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select qty, p_price from cart_tbl where user_id = '"+user_id+"'", con);
            da.Fill(ds);

            int numberOfRows=0;
            if (ds.Tables.Count > 0)
            {
                numberOfRows = ds.Tables[0].Rows.Count;
            }
            int subtotal=0;

            for (int i = 0; i < numberOfRows; i++)
            {
                int quantity = Convert.ToInt32(ds.Tables[0].Rows[i]["qty"]);
                int price = Convert.ToInt32(ds.Tables[0].Rows[i]["p_price"]);
                subtotal = subtotal + (quantity * price);
            }
            con.Close();
            return subtotal;
        }
        public DataSet selectUserWishItems(string u_id)
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from wishlist_tbl where user_id='" + u_id + "'", con);
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void removeFromWish(Page page, int cart_id, string user_id)
        {
            con = getCon();
            cmd = new SqlCommand("delete from wishlist_tbl where wish_id = '" + cart_id + "'", con);
            cmd.ExecuteNonQuery();
            page.ClientScript.RegisterStartupScript(page.GetType(), "alert", "alert('Item Removed from Wishlist.');", true);
            if (!checkCartItem(user_id))
            {
                page.Response.Redirect("noWish.aspx");
            }
            con.Close();
        }
        public string GetProductIdsAndQuantities(string user_id)
        {
            List<string> productInfoList = new List<string>();

            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select p_id, qty from cart_tbl where user_id = '" + user_id + "'", con);
            da.Fill(ds);

            int numberOfRows = 0;
            if (ds.Tables.Count > 0)
            {
                numberOfRows = ds.Tables[0].Rows.Count;
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                int productId = Convert.ToInt32(ds.Tables[0].Rows[i]["p_id"]);
                int quantity = Convert.ToInt32(ds.Tables[0].Rows[i]["qty"]);
                string productInfo = productId + ":" + quantity; 
                productInfoList.Add(productInfo);
            }

            con.Close();
            string productInfoString = string.Join(",", productInfoList);

            return productInfoString;
        }

        public void insertorder(int u_id, int total, string order_products_qty,string pre_name, string name, string email, string mno, string address1, string address2, string city, string state, string zip, string country, string payment, string status)
        {
            con = getCon();
            cmd = new SqlCommand("insert into order_tbl (user_id,total,order_products_qty,pre_name,name,email,mno,address1,address2,city,state,zip,country,payment,status) " +
                "values ('" + u_id + "','" + total + "','"+ order_products_qty + "','"+ pre_name + "','" + name + "','" + email + "','" + mno + "','" + address1 + "','" + address2 + "','" + city + "','" + state + "','" + zip + "','" + country + "','" + payment + "','" + status + "')", con);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("delete from cart_tbl where user_id = '"+u_id+"'", con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public DataSet fillFilterCombBox()
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from category_tbl", con);
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet getTestimonails()
        {
            con = getCon();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from testimonial_tbl", con);
            da.Fill(ds);
            con.Close();
            return ds;
        }

    }
}