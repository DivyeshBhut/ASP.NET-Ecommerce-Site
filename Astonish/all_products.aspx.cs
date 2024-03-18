using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class all_products : System.Web.UI.Page
    {
        Class1 cs;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadAllProducts();
            if (!IsPostBack)
            {
                setFilterCategory();
            }
        }
        public void loadAllProducts()
        {
            cs = new Class1();
            ds = cs.getAllProducts();

            DataListAllProducts.DataSource = ds;
            DataListAllProducts.DataBind();

        }
        public void setFilterCategory()
        {
            cs = new Class1();
            ds = cs.fillFilterCombBox();

            dropDownFilter.Items.Add(new ListItem("All Products", "0"));

            int rowcount = ds.Tables[0].Rows.Count;

            for (int i = 0; i < rowcount; i++)
            {
                string c_name = ds.Tables[0].Rows[i]["c_name"].ToString();
                string c_id = ds.Tables[0].Rows[i]["c_id"].ToString();
                dropDownFilter.Items.Add(new ListItem(c_name, c_id));
            }
        }

        protected void dropDownFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(dropDownFilter.SelectedValue);
            cs = new Class1();

            if (selectedValue == 0)
            {
                loadAllProducts();
            }
            else
            {
                ds = cs.getCategoryProducts(selectedValue);
                DataListAllProducts.DataSource = ds;
                DataListAllProducts.DataBind();
            }
        }
    }
}