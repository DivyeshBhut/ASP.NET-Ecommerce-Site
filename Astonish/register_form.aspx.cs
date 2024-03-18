using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish
{
    public partial class register_form : System.Web.UI.Page
    {
        Class1 cs;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void clearFiled()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPwd.Text = "";
            txtCPwd.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtEmail.Text) 
                && !string.IsNullOrEmpty(txtPwd.Text) && !string.IsNullOrEmpty(txtCPwd.Text))
            {
                if (txtPwd.Text.Equals(txtCPwd.Text))
                {
                    cs = new Class1();
                    cs.registerNewUser(this, txtName.Text, txtEmail.Text, txtPwd.Text, ddlUserType.SelectedValue);
                    clearFiled();
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Both Passwords are not match.');", true);
                }
               
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Please fill in all fields.');", true);
            }
        }
    }
}