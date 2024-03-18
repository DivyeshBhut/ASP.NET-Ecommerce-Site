using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Astonish.admin
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Write("<script>alert('Logout Sucessfully!');</script>");
            Response.Write("<script>window.location.href='../login_form.aspx'</script>");
            Response.Redirect("dashboard.aspx");
        }
    }
}