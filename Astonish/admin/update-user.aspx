<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="update-user.aspx.cs" Inherits="Astonish.admin.update_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <main>
                <div class="container-fluid px-4">
                    <h1 class="mt-4">Update User</h1>
                    <ol class="breadcrumb mb-4">
                        <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                        <li class="breadcrumb-item active">Update User</li>
                    </ol>
                    <div class="card mb-4">
                        <div class="card-body">

                            <form method="">
                                <div class="row">

                                    <div class="col-4">User ID</div>
                                    <div class="col-6">
                                        <%--<input type="text" value="user_id" name="userid" class="form-control" required>--%>

                                    </div>

                                    <div class="col-4" style="margin-top:10px;">User Name</div>
                                    <div class="col-6" style="margin-top:10px;">
                                        <%--<input type="text" value="name" name="username" class="form-control" required>--%>
                                    </div>

                                    <div class="col-4" style="margin-top:10px;">User Email</div>
                                    <div class="col-6" style="margin-top:10px;">
                                        <%--<input type="email" value="email" name="useremail" class="form-control" required>--%>
                                    </div>

                                    <div class="col-4" style="margin-top:10px;">User Type</div>
                                    <div class="col-6" style="margin-top:10px;">
                                        <%--<input type="text" value="user_type" name="usertype" class="form-control" required>--%>
                                    </div>

                                </div>

                                <div class="row" style="margin-left:500px; margin-top:20px">
                                    <div class="col-2">
                                        <%--<button type="submit" name="submit" class="btn btn-primary">Update</button>--%>
                                        <asp:LinkButton ID="btnUpdate" runat="server">LinkButton</asp:LinkButton>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </main>
</asp:Content>

