<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="add-category.aspx.cs" Inherits="Astonish.admin.add_category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <main>
        <div class="container-fluid px-4">
            <h1 class="mt-4">Add Category</h1>
            <ol class="breadcrumb mb-4">
                <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                <li class="breadcrumb-item active">Add Category</li>
            </ol>
            <div class="card mb-4">
                <div class="card-body">
                    <form method="post">
                        <div class="row">

                            <!-- <div class="col-4">Category ID</div>
                                    <div class="col-6"><input type="text" placeholder="Enter category ID" name="c_id"
                                            class="form-control" required></div> -->


                            <div class="col-4" style="margin-top: 10px;">Category Name</div>
                            <div class="col-6" style="margin-top: 10px;">
                                <%--<input type="text" placeholder="Enter category Name" name="c_name" class="form-control" required>--%>
                                <asp:TextBox ID="c_name" runat="server" placeholder="Enter category Name" class="form-control"></asp:TextBox>
                            </div>

                        </div>

                        <div class="row" style="margin-left: 500px; margin-top: 20px">
                            <div class="col-2">
                                <%--<button type="submit" name="submit" class="btn btn-primary">Submit</button>--%>
                                <asp:LinkButton ID="btnsubmit" runat="server" class="btn btn-primary" OnClick="btnsubmit_Click">Submit</asp:LinkButton>
                            </div>
                        </div>

                    </form>
                </div>
            </div>
        </div>
    </main>
</asp:Content>

