using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class catagory_product : System.Web.UI.Page
    {
        Class1 cs;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = new Class1();
            ds = cs.getCategoryProducts(3);

            DataListAllProducts.DataSource = ds;
            DataListAllProducts.DataBind();
        }
    }
}