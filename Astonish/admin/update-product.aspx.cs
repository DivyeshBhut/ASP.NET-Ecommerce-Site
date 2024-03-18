using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Astonish.admin;
using System.IO;

namespace Astonish.admin
{
    public partial class update_product : System.Web.UI.Page
    {
        DataSet ds;
        AdminClass cs;
        string fnm;
        int id;
        int numOfCategory;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
            PopulateCategoryDropDown();
            if (!IsPostBack)
            {
                fillFields();
            }
        }
        void getcon()
        {
            cs = new AdminClass();
            cs.getCon();
        }
        void imgupload()
        {
            if (p_img.HasFile)
            {
                fnm = "../assets/product-image/" + p_img.FileName;
                p_img.SaveAs(Server.MapPath(fnm));
            }
            else
            {
                DataSet checkds = cs.getOneProduct(Convert.ToInt32(Request.QueryString["id"]));
                fnm = checkds.Tables[0].Rows[0]["p_img"].ToString();
            }

        }
        void fillFields()
        {
            if (Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                cs = new AdminClass();
                ds = cs.getOneProduct(id);
                p_name.Text = (ds.Tables[0].Rows[0][1]).ToString();
                fnm = (ds.Tables[0].Rows[0][2]).ToString();
                p_mrp.Text = (ds.Tables[0].Rows[0][3]).ToString();
                p_price.Text = (ds.Tables[0].Rows[0][4]).ToString();
                p_desc.Text = (ds.Tables[0].Rows[0][5]).ToString();
                categoryDropDown.SelectedIndex = Convert.ToInt32((ds.Tables[0].Rows[0][6]).ToString());
            }
        }
        void PopulateCategoryDropDown()
        {
            cs = new AdminClass();
            ds = cs.getCategory();

            numOfCategory = ds.Tables[0].Rows.Count;

            for (int i = 0; i < numOfCategory; i++)
            {
                categoryDropDown.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            cs = new AdminClass();

            imgupload();

            cs.updateProduct(Convert.ToInt32(Request.QueryString["id"]), p_name.Text, fnm, Convert.ToInt32(p_mrp.Text), Convert.ToInt32(p_price.Text), p_desc.Text, categoryDropDown.SelectedIndex, Convert.ToInt32(qty.Text));
            Response.Write("<script>alert('Product Updated Successfully');</script>");
            Response.Write("<script>window.location.href='manage-product.aspx'</script>");
        }
    }
}