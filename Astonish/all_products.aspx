<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="all_products.aspx.cs" Inherits="Astonish.all_products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
        </div>
    </div>

    <div class="products">
        <div class="container">
            <div style="background-color: #edeff0; height: 60px; margin-top: 100px; display: flex; justify-content: flex-end;">
                <span style="margin-right:50px; margin-top:8px;">
                    <asp:DropDownList ID="dropDownFilter" runat="server" AutoPostBack="true" style="padding: 8px; border: 1px solid #ccc; background-color: #fff; font-size: 16px; color: #333;" OnSelectedIndexChanged="dropDownFilter_SelectedIndexChanged">
                       
                    </asp:DropDownList>
                </span>
            </div>
            <div class="row">

                <asp:DataList ID="DataListAllProducts" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <%--<div class="col-md-4">--%>
                        <div class="product-item" style="margin: 15px;">
                            <a href='<%# "product_details.aspx?ProductId=" + Eval("p_id") %>'>
                                <img src='<%# Eval("p_img") %>' alt='<%# Eval("p_name") %>' />
                            </a>
                            <div class="down-content">
                                <a href='<%# "product_details.aspx?ProductId=" + Eval("p_id") %>'>
                                    <h4><%# Eval("p_name") %></h4>
                                </a>
                                <h6><small><del>₹<%# Eval("p_mrp") %></del></small>₹<%# Eval("p_price") %></h6>
                                <p><%# Eval("p_desc") %></p>
                            </div>
                        </div>
                        <%--</div>--%>
                    </ItemTemplate>
                </asp:DataList>

            </div>
        </div>
    </div>

</asp:Content>
