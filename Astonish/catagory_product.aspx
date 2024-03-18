<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="catagory_product.aspx.cs" Inherits="Astonish.catagory_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
        </div>
      </div>

    <div class="products">
      <div class="container">
        <div class="row">

           <asp:DataList ID="DataListAllProducts" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <%--<div class="col-md-4">--%>
                        <div class="product-item" style="margin:15px;">
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

          
          <div class="col-md-12">
            <ul class="pages">
              <li class="active"><a href="#">1</a></li>
              <li><a href="#">2</a></li>
              <li><a href="#">3</a></li>
              <li><a href="#">4</a></li>
              <li><a href="#"><i class="fa fa-angle-double-right"></i></a></li>
            </ul>
          </div>
        </div>
      </div>
    </div>

</asp:Content>