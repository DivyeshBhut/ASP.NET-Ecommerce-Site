<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="product_details.aspx.cs" Inherits="Astonish.product_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
        </div>
    </div>

    <div class="products">
        <div class="container">
            <div class="row">

                <div class="col-md-4 col-xs-12">
                    <div>
                        <asp:Image runat="server" class="img-fluid wc-image" ID="imgProductImage"></asp:Image>
                        <%--<img src="assets\product-image\18-min_720x.jpg" alt="" >--%>
                    </div>
                    <br>
                </div>

                <div class="col-md-8 col-xs-12">
                    <h2>
                        <asp:Label runat="server" Text="Label" ID="lblProductName"></asp:Label>
                    </h2>
                    <br />

                    <div class="star" style="color: #FFD700;">
                        <span class="fa fa-star checked"></span>
                        <span class="fa fa-star checked"></span>
                        <span class="fa fa-star checked"></span>
                        <span class="fa fa-star checked"></span>
                        <span class="fa fa-star checked"></span>
                        <span style="color: black; font-size: 13px;">Reviews</span>
                    </div>
                    <br>

                    <p class="lead" style="font-weight: 500">
                        <asp:Label runat="server" Text="Prodcuts desc" ID="lblProductDesc"></asp:Label>
                    </p>

                    <br>

                    <p>Fragrance free • Non-comedogenic</p>
                    <br>
                    <p class="lead">
                        <small><del>₹<asp:Label runat="server" Text="500" ID="lblProductMrp"></asp:Label></del></small><strong class="text-dark"
                            style="font-weight: 500;">₹<asp:Label runat="server" Text="470" ID="lblProductPrice"></asp:Label></strong>
                    </p>
                    <br>

                    <p style="margin-top: -20px; font-size: 13px; font-weight: normal bold;">Inclusive of all taxes</p>
                    <br>
                    <hr />

                    <div class="row">
                        <div class="col-sm-8">
                            <label class="control-label" style="font-weight: bold">Quantity</label>

                            <div class="row">
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <asp:TextBox ID="txtQty" runat="server" CssClass="form-control form-control-lg text-center"
                                            Text="1" Width="85px" TextMode="Number" min="1" max="10">
                                        </asp:TextBox>

                                        <%--<input type="number" class="form-control form-control-lg text-center"
                                            name="qty" value="1" min="1" max="10" style="width: 85px;">--%>
                                    </div>
                                </div>
                                <div class="col-sm-6" style="margin-top:12px;">
                                    <asp:LinkButton runat="server" ID="btnAddToWish" OnClick="btnAddToWish_Click">
                <span style="margin-top: 5.5px; margin-left: 25px; height: 35px; border:solid #212529 2px; padding:5px; border-radius:5px;">❤️</span>
                                    </asp:LinkButton>

                                    <asp:LinkButton Style="margin-top: -31px; margin-left: -130px; width: 150px;" class="btn btn-dark btn-block" runat="server" ID="btnAddToCart" OnClick="btnAddToCart_Click">Add To Cart</asp:LinkButton>
                                    <%--<input type="submit" class="btn btn-dark btn-block"
                                        style="margin-top: -36px; margin-left: -130px; width: 150px;"
                                        name="noLogin" value="Add To Cart">--%>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class="latest-products">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">
                        <h2>Similar Products</h2>
                        <asp:LinkButton runat="server" ID="btnViewMoreProductDetails" OnClick="btnViewMoreProductDetails_Click">view more <i class="fa fa-angle-right"></i></asp:LinkButton>
                        <%--<a href="products.html">view more <i class="fa fa-angle-right"></i></a>--%>
                    </div>
                </div>


                <%--<div class="col-md-4">
                    <div class="product-item">
                        <a href="product-details.html">
                            <img src="assets\product-image\18-min_720x.jpg" alt=""></a>
                        <div class="down-content">
                            <a href="product-details.html">
                                <h4>product name</h4>
                            </a>
                            <h6><small><del>₹500</del></small>₹450</h6>
                        </div>
                    </div>
                </div>--%>

                <asp:DataList ID="DataListSimilarProducts" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <%--<div class="col-md-4">--%>
                        <div class="product-item" style="margin: 15px">
                            <a href='<%# "product_details.aspx?ProductId=" + Eval("p_id") %>'>
                                <img src='<%# Eval("p_img") %>' alt="" /></a>
                            <div class="down-content">
                                <a href='<%# "product-details.aspx?ProductId=" + Eval("p_id") %>'>
                                    <h4><%# Eval("p_name") %></h4>
                                </a>
                                <h6>
                                    <small><del>₹<%# Eval("p_mrp") %></del></small>
                                    ₹<%# Eval("p_price") %>
                                </h6>
                            </div>
                        </div>
                        <%--</div>--%>
                    </ItemTemplate>
                </asp:DataList>

            </div>
        </div>
    </div>
</asp:Content>
