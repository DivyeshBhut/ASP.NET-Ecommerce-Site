<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="Astonish.cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="pt-5 pb-5">
        <div class="container">
            <div class="row w-100">
                <div class="col-lg-12 col-md-12 col-12" style="margin-top: 60px;">
                    <h3 class="display-5 mb-2 text-center">Shopping Cart</h3>
                    <p class="mb-5 text-center">
                        <i class="text-dark font-weight-bold">
                            <asp:Label ID="lblnumOfCartItems" runat="server" Text="Label"></asp:Label></i> items in your cart
                    </p>

                    <asp:DataList ID="DataListCart" runat="server" CssClass="table table-condensed table-responsive" OnItemCommand="DataListCart_ItemCommand">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-3 text-left">
                                    <asp:Image ID="imgProduct" runat="server" src='<%# Eval("p_img") %>' CssClass="img-fluid d-none d-md-block rounded mb-2 shadow" />
                                </div>
                                <div class="col-md-9 text-left mt-sm-2">
                                    <h4><%# Eval("p_name") %></h4>
                                    <p style="font-size:15px; font-weight:500; margin-top:8px;">Price: ₹<%# Eval("p_price") %></p>
                                    <div style="margin-top:25px; ">
                                    <asp:LinkButton runat="server" ID="btnMinus" CommandName="cmd_minus" CommandArgument='<%# Eval("cart_id") %>'>
                                            <span style="margin-top: 5.5px; height:25px; border:solid grey 2px; padding:5px 8px 5px 8px;"><i style="color:black;" class="fa fa-minus"></i></span>
                                    </asp:LinkButton> 

                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("qty") %>' style="margin-top: 5.5px; height:25px; border:solid grey 2px; padding:5px 12px 5px 12px;"></asp:Label>
                                    
                                        <asp:LinkButton runat="server" ID="btnPlus" CommandName="cmd_plus" CommandArgument='<%# Eval("cart_id") %>'>
                                            <span style="margin-top: 5.5px; height:25px; border:solid grey 2px; padding:5px 8px 5px 8px;"><i style="color:black;" class="fa fa-plus"></i></span>
                                    </asp:LinkButton>
                                        </div>
                                    <div class="text-right" style="margin-top:-100px;">
                                         <asp:LinkButton runat="server" ID="btnRemoveProduct" CommandName="cmd_close" CommandArgument='<%# Eval("cart_id") %>'>
                                            <span style="margin-left: 25px; height: 35px; border:solid grey 2px; padding:5px 8px 5px 8px; border-radius:5px;"><i style="color:grey;" class="fa fa-close"></i></span>
                                    </asp:LinkButton>
                                        <%--<asp:Button ID="btnRemove" runat="server" Text="Remove" CssClass="btn btn-white border-secondary bg-white btn-md mb-2" CommandArgument='<%# Eval("cart_id") %>' />--%>
                                    </div>
                                </div>
                            </div>
                            <hr />
                        </ItemTemplate>
                    </asp:DataList>

                    <div class="float-right text-right">
                        <h4>Subtotal:</h4>
                        <h1>₹<asp:Label ID="lblSubtotal" runat="server" Text="0"></asp:Label></h1>
                        <!-- Replace with actual subtotal value -->
                    </div>
                </div>
            </div>

            <div class="row mt-4 d-flex align-items-right">
                <div class="col-sm-6 order-md-2 text-right">
                    <asp:Button ID="btnCheckout" runat="server" Text="Checkout" CssClass="btn btn-dark mb-4 btn-lg pl-5 pr-5" OnClick="btnCheckout_Click" />
                    <asp:HiddenField ID="hdnSubtotal" runat="server" />
                </div>
                <div class="col-sm-6 mb-3 mb-m-1 order-md-1 text-md-left">
                    <a href="index.aspx" style="color: black">
                        <i class="fa fa-arrow-left" aria-hidden="true"></i>Continue Shopping
                    </a>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
