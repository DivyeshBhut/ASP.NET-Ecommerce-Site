<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="update-product.aspx.cs" Inherits="Astonish.admin.update_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
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
                            <div class="col-2">Category Name</div>
                            <div class="col-6">
                                <%--<select name="c_id" class="form-control" required>
                                    <option value="c_id" selected>c_name</option>
                                    <option value="c_id">c_name</option>
                                </select>--%>
                                <asp:DropDownList ID="categoryDropDown" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="-- Choose Category --" Value=""></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>


                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Name</div>
                            <div class="col-6">
                                <%--<input type="text" name="p_name" value="p_name" class="form-control" required />--%>
                                <asp:TextBox ID="p_name" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Image</div>
                            <div class="col-6">
                                <%--<input type="file" name="p_img" value="p_img" class="form-control" />--%>
                                <asp:FileUpload ID="p_img" runat="server" class="form-control"/>
                            </div>
                            <div>
                                <%--<input type="hidden" value="p_img" name="img" /></div>--%>
                                
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product MRP</div>
                            <div class="col-6">
                                <%--<input type="text" name="p_mrp" value="p_mrp" class="form-control" />--%>
                                <asp:TextBox ID="p_mrp" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Price</div>
                            <div class="col-6">
                                <%--<input type="text" name="p_price" value="p_price" class="form-control" />--%>
                                <asp:TextBox ID="p_price" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Qty</div>
                            <div class="col-6">
                                <%--<input type="text" name="qty" value="qty" class="form-control" />--%>
                                <asp:TextBox ID="qty" runat="server" Text="1" class="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Description</div>
                            <div class="col-6">
                                <%--<textarea name="p_desc" class="form-control">p_desc</textarea>--%>
                                <asp:TextBox ID="p_desc" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%">
                            <div class="col-2">&nbsp;</div>
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

