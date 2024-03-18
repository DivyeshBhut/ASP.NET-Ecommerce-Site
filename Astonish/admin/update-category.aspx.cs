using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Astonish.admin;

namespace Astonish.admin
{
    public partial class update_category : System.Web.UI.Page
    {
        DataSet ds;
        int id;
        AdminClass cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
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
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            cs = new AdminClass();
            cs.updateCategory(this,c_name.Text, Request.QueryString["id"]);
            c_name.Text = "";
        }
        public void fillFields()
        {
            if (Request.QueryString["id"] != null)
            {
                cs = new AdminClass();
                id = Convert.ToInt32(Request.QueryString["id"]);
                ds = cs.getOneCategory(id);
                c_id.Text = id.ToString();
                c_name.Text = (ds.Tables[0].Rows[0][1]).ToString();
            }
        }
    }
 }