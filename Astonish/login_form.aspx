<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_form.aspx.cs" Inherits="Astonish.login_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>login form</title>

    <!-- custom css file link  -->
    <link rel="stylesheet" href="assets/css/login.css" />

</head>
<body>
    <div class="form-container">
        <form id="form1" runat="server">
            <h3>login now</h3>

            <asp:TextBox ID="txtEmail" runat="server" type="email" name="email" required="required" placeholder="enter your email"></asp:TextBox>

            <asp:TextBox ID="txtPassword" runat="server" type="password" name="password" required="required" placeholder="enter your password"></asp:TextBox>

           <asp:Button ID="Button1" runat="server" Text="Login" CssClass="form-btn" Font-Names="Yu Gothic UI Semibold" Font-Size="Large" OnClick="Button1_Click" />

            <p>don't have an account? <a href="register_form.aspx">register now</a></p>

            <a href="index.aspx" style="font-size: 15px; line-height: 50px; color: black;"><span style="text-decoration: underline;">Home</span></a>
        </form>
    </div>
</body>
</html>
