<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="update-testimonials.aspx.cs" Inherits="Astonish.admin.update_testimonials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <main>
        <div class="container-fluid px-4">
            <h1 class="mt-4">Update Testimonials</h1>
            <ol class="breadcrumb mb-4">
                <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                <li class="breadcrumb-item active">Update Testimonials</li>
            </ol>
            <div class="card mb-4">
                <div class="card-body">

                    <form method="" >
                        <div class="row">

                            <div class="col-4" style="margin-top: 10px;">Testimonial Name</div>
                            <div class="col-6" style="margin-top: 10px;">
                                <%--<input type="text" value="name" name="testimonial_name" class="form-control" required>--%>
                                <asp:TextBox ID="testimonial_name" runat="server" class="form-control"></asp:TextBox>
                            </div>

                            <div class="col-4" style="margin-top: 10px;">Testimonial</div>
                            <div class="col-6" style="margin-top: 10px;">
                                <%--<textarea name="testimonial_data" class="form-control" required>testimonial_data</textarea>--%>
                                <asp:TextBox ID="testimonial_data" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>

                        </div>

                        <div class="row" style="margin-left: 500px; margin-top: 20px">
                            <div class="col-2">
                                <%--<button type="submit" name="submit" class="btn btn-primary">Update</button>--%>
                                <asp:LinkButton ID="btnupdate" runat="server" class="btn btn-primary" OnClick="btnupdate_Click">Update</asp:LinkButton>
                            </div>
                        </div>

                    </form>

                </div>
            </div>
        </div>
    </main>
</asp:Content>

