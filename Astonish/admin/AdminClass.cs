using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace Astonish.admin
{
    public class AdminClass
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
        public void addCategory(Page page,string c_name)
        {
            con = getCon();
            cmd = new SqlCommand("insert into category_tbl (c_name) values('" + c_name + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataSet getCategory()
        {
            con = getCon();
            da = new SqlDataAdapter("select * from category_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet getOneCategory(int c_id)
        {
            con = getCon();
            da = new SqlDataAdapter("select * from category_tbl where c_id='"+c_id+"'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void deleteCategory(Page page, string c_id)
        {
            con = getCon();
            cmd = new SqlCommand("delete from category_tbl where c_id ='" + c_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateCategory(Page page, string name,string c_id)
        {
            con = getCon();
            cmd = new SqlCommand("update category_tbl set c_name='" + name + "' where c_id='" + c_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Products 
        public void addProduct(Page page, string p_name, string p_img, int p_mrp, int p_price, string p_desc, int c_id, int qty)
        {
            con = getCon();
            cmd = new SqlCommand("insert into product_tbl (p_name,p_img,p_mrp,p_price,p_desc,c_id,qty) values('" + p_name + "','" + p_img + "','" + p_mrp + "','" + p_price + "','" + p_desc + "','" + c_id + "','" + qty + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
         }
        public DataSet getProduct()
        {
            con = getCon();
            da = new SqlDataAdapter("select * from product_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet getOneProduct(int p_id)
        {
            con = getCon();
            da = new SqlDataAdapter("select * from product_tbl where p_id='" + p_id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void deleteProduct(string p_id)
        {
            con = getCon();
            cmd = new SqlCommand("delete from product_tbl where p_id ='" + p_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateProduct(int p_id, string p_name, string p_img,int p_mrp, int p_price,string p_desc,int c_id,int qty)
        {
            con = getCon();
            cmd = new SqlCommand("update product_tbl set p_name = '"+p_name+"', p_img = '"+p_img+"', p_mrp = '"+p_mrp+"', p_price = '"+p_price+"', p_desc = '"+p_desc+"', c_id = '"+c_id+"', qty = '"+qty+"' where p_id = '"+p_id+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //testimonial
        public void addTestimonial(string t_name, string t_data)
        {
            con = getCon();
            cmd = new SqlCommand("insert into testimonial_tbl (name,testimonial_data) values('" + t_name + "','" + t_data + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataSet getTestimonial()
        {
            con = getCon();
            da = new SqlDataAdapter("select * from testimonial_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public DataSet getOneTesimonial(int testimonial_id)
        {
            con = getCon();
            da = new SqlDataAdapter("select * from testimonial_tbl where testimonial_id='" + testimonial_id + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void deleteTestimonial(string testimonial_id)
        {
            con = getCon();
            cmd = new SqlCommand("delete from testimonial_tbl where testimonial_id ='" + testimonial_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateTestimonial(int testimonial_id, string name, string testimonial_data)
        {
            con = getCon();
            cmd = new SqlCommand("update testimonial_tbl set name = '" + name + "', testimonial_data = '" + testimonial_data + "' where testimonial_id = '" + testimonial_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //user
        public DataSet getusers()
        {
            con = getCon();
            da = new SqlDataAdapter("select * from user_tbl where user_type='User'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        //getCount 
        public int getProductCount()
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from product_tbl", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }
        public int getTestimonialCount()
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from testimonial_tbl", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }

        public int getUserCount()
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from user_tbl where user_type='User'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }

        public int getCategoryCount()
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from category_tbl", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }
        public int getOrderCount()
        {
            con = getCon();
            cmd = new SqlCommand("select count(*) from order_tbl", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }
        //Orders
        public DataSet getOrders()
        {
            con = getCon();
            da = new SqlDataAdapter("select * from order_tbl", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
        public void deleteOrder(string order_id)
        {
            con = getCon();
            cmd = new SqlCommand("delete from order_tbl where order_id ='" + order_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updateOrder(int order_id, string status)
        {
            con = getCon();
            cmd = new SqlCommand("update order_tbl set status = '" + status + "' where order_id = '" + order_id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}