<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="update-order.aspx.cs" Inherits="Astonish.admin.update_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <main>
        <div class="container-fluid px-4">
            <h1 class="mt-4">Update Product</h1>
            <ol class="breadcrumb mb-4">
                <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                <li class="breadcrumb-item active">Update Product</li>
            </ol>
            <div class="card mb-4">
                <div class="card-body">

                    <form method="post" enctype="multipart/form-data">
                        <div class="row">
                            <div class="col-2">Order Status Name</div>
                            <div class="col-6">
                                <%--<select name="c_id" class="form-control" required>
                                    <option value="c_id" selected>c_name</option>
                                    <option value="c_id">c_name</option>
                                </select>--%>
                                <asp:DropDownList ID="ddlOrderStatus" runat="server" CssClass="form-control">
                                    <asp:ListItem>Order Confirm</asp:ListItem>
                                    <asp:ListItem>Order Packed</asp:ListItem>
                                    <asp:ListItem>Order Deliverd Soon</asp:ListItem>
                                    <asp:ListItem>Out Of Delivery</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="row" style="margin-top: 1%">
                            <div class="col-2">&nbsp;</div>
                            <div class="col-2">
                                <asp:LinkButton ID="btnupdate" runat="server" class="btn btn-primary" OnClick="btnupdate_Click">Update</asp:LinkButton>
                            </div>
                        </div>
                    </form>

                </div>
            </div>
        </div>

    </main>
</asp:Content>
