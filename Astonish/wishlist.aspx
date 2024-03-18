<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="wishlist.aspx.cs" Inherits="Astonish.wishlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="pt-5 pb-5">
        <div class="container">
            <div class="row w-100">
                <div class="col-lg-12 col-md-12 col-12" style="margin-top: 60px;">
                    <h3 class="display-5 mb-2 text-center">Wishlist</h3>
                    <p class="mb-5 text-center">
                        <i class="text-dark font-weight-bold">
                            <asp:Label ID="lblnumOfWishItems" runat="server" Text="Label"></asp:Label></i> items in your Wishlist
                    </p>

                    <asp:DataList ID="DataListWish" runat="server" CssClass="table table-condensed table-responsive" OnItemCommand="DataListCart_ItemCommand">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-3 text-left">
                                    <asp:Image ID="imgProduct" runat="server" src='<%# Eval("p_img") %>' CssClass="img-fluid d-none d-md-block rounded mb-2 shadow" />
                                </div>
                                <div class="col-md-9 text-left mt-sm-2">
                                    <h4><%# Eval("p_name") %></h4>
                                    <p style="font-size:15px; font-weight:500; margin-top:8px;">Price: ₹<%# Eval("p_price") %></p>
                                   
                                    <div class="text-right" style="margin-top:-50px;">
                                         <asp:LinkButton runat="server" ID="btnRemoveProduct" CommandName="cmd_close" CommandArgument='<%# Eval("wish_id") %>'>
                                            <span style="margin-left: 25px; height: 35px; border:solid grey 2px; padding:5px 8px 5px 8px; border-radius:5px;"><i style="color:grey;" class="fa fa-close"></i></span>
                                    </asp:LinkButton>
                                        <%--<asp:Button ID="btnRemove" runat="server" Text="Remove" CssClass="btn btn-white border-secondary bg-white btn-md mb-2" CommandArgument='<%# Eval("cart_id") %>' />--%>
                                    </div>
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:DataList>

                   
                </div>
            </div>

            <div class="col-sm-6 mb-3 mb-m-1 order-md-1 text-md-left" style="margin-left: 450px;">
                <a href="index.aspx" style="color: black">
                        <i class="fa fa-arrow-left" aria-hidden="true"></i>Continue Shopping
                    </a>
            </div>
        </div>
    </section>
</asp:Content>
