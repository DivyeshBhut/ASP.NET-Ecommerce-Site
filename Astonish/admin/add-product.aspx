<%@ Page Title="" Language="C#" MasterPageFile="~/admin_master.Master" AutoEventWireup="true" CodeBehind="add-product.aspx.cs" Inherits="Astonish.admin.add_product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <main>
        <div class="container-fluid px-4">
            <h1 class="mt-4">Add Product</h1>
            <ol class="breadcrumb mb-4">
                <li class="breadcrumb-item"><a href="dashboard.aspx">Dashboard</a></li>
                <li class="breadcrumb-item active">Add Product</li>
            </ol>
            <div class="card mb-4">
                <div class="card-body">
                    <form method="post" enctype="multipart/form-data">
                        <div class="row">
                            <div class="col-2">Category Name</div>
                            <div class="col-6">
                                <%--<select name="category" id="category" class="form-control" required>
                                            <option value="">Select Category</option>
                                            <option value="eyes">
                                               eyes
                                            </option>
                                        </select>--%>
                                <asp:DropDownList ID="categoryDropDown" runat="server" CssClass="form-control">
                                    <asp:ListItem Text="---Select Category---" Value=""></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>


                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Name</div>
                            <div class="col-6">
                                <%--<input type="text" name="p_name" placeholder="Enter the Product Name" class="form-control" />--%>
                                <asp:TextBox ID="p_name" runat="server" placeholder="Enter the Product Name" class="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Image</div>
                            <div class="col-6">
                                <%--<input type="file" name="p_img" class="form-control" required />--%>
                                <asp:FileUpload ID="p_img" runat="server" class="form-control" />
                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product MRP</div>
                            <div class="col-6">
                                <%--<input type="text" name="p_mrp" placeholder="Enter the Product MRP" class="form-control" />--%>
                                <asp:TextBox ID="p_mrp" runat="server" placeholder="Enter the Product MRP" class="form-control"></asp:TextBox>
                            </div>
                        </div>



                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Price</div>
                            <div class="col-6">
                                <%--<input type="text" name="p_price" placeholder="Enter the Product Price" class="form-control" />--%>
                                <asp:TextBox ID="p_price" runat="server" placeholder="Enter the Product Price" class="form-control"></asp:TextBox>
                            </div>
                        </div>


                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Qty</div>
                            <div class="col-6">
                                <%--<input type="text" name="qty" placeholder="Enter the Product Qty" value="1" class="form-control" />--%>
                                <asp:TextBox ID="qty" runat="server" placeholder="Enter the Product Qty" Text="1" class="form-control"></asp:TextBox>

                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%;">
                            <div class="col-2">Product Description</div>
                            <div class="col-6">
                                <%--<textarea name="p_desc" rows="6" class="form-control"></textarea>--%>
                                <asp:TextBox ID="p_desc" runat="server" placeholder="Enter the Product Description" class="form-control" TextMode="MultiLine"></asp:TextBox>

                            </div>
                        </div>

                        <div class="row" style="margin-top: 1%">
                            <div class="col-2">&nbsp;</div>
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

