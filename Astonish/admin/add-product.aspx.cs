﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Astonish.admin;

namespace Astonish.admin
{

    public partial class add_product : System.Web.UI.Page
    {
        AdminClass cs;
        SqlConnection con;
        DataSet ds;
        string fnm;
        int numOfCategory;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
            PopulateCategoryDropDown();
        }
        void getcon()
        {
            cs = new AdminClass();
            con = cs.getCon();
        }
        void imgupload()
        {
            fnm = "../assets/product-image/" + p_img.FileName;
            p_img.SaveAs(Server.MapPath(fnm));
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
        public void clearFields()
        {
            p_name.Text = "";
            fnm = "";
            p_mrp.Text = "";
            p_price.Text = "";
            p_desc.Text = "";
            qty.Text = "";
        }
        
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            imgupload();
            cs = new AdminClass();
            cs.addProduct(this, p_name.Text, fnm, Convert.ToInt32(p_mrp.Text), Convert.ToInt32(p_price.Text),p_desc.Text,categoryDropDown.SelectedIndex, Convert.ToInt32(qty.Text));
            Response.Write("<script>alert('Product added successfully');</script>");
            clearFields();
        }
    }
}