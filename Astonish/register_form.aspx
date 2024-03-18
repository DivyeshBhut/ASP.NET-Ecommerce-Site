<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register_form.aspx.cs" Inherits="Astonish.register_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>register form</title>

    <!-- custom css file link  -->
    <link rel="stylesheet" href="assets/css/login.css" />
</head>
<body>
    <div class="form-container">
        <form id="form1" runat="server">

            <h3>register now</h3>

            <asp:TextBox ID="txtName" type="text" name="name" runat="server" placeholder="enter your name"></asp:TextBox>

            <asp:TextBox ID="txtEmail" type="email" name="email" runat="server" placeholder="enter your email"></asp:TextBox>

            <asp:TextBox ID="txtPwd" runat="server" type="password" name="password" placeholder="enter your password"></asp:TextBox>

            <asp:TextBox ID="txtCPwd" runat="server" type="password" name="cpassword" placeholder="confirm your password"></asp:TextBox>

            <asp:DropDownList name="user_type" ID="ddlUserType" runat="server">
                <asp:ListItem>User</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="Button1" runat="server" Text="Register Now" CssClass="form-btn" Font-Names="Yu Gothic UI Semibold" Font-Size="Large" OnClick="Button1_Click" />

            <p>already have an account? <a href="login_form.aspx">login now</a></p>
        </form>
    </div>
</body>
</html>
