<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="noWish.aspx.cs" Inherits="Astonish.noWish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row">
        </div>
    </div>

    <section class="pt-5 pb-5">
        <div class="container">
            <div class="row w-100">
                <div class="col-lg-12 col-md-12 col-12" style="margin-top:60px;">
                    <h3 class="display-5 mb-2 text-center">Wishlist</h3>
                    <p class="mb-5 text-center">
                        <i class="text-dark font-weight-bold">0</i> items in your Wishlist
                    </p>

                </div>
            </div>
            <div class="col-sm-6 mb-3 mb-m-1 order-md-1 text-md-left" style="margin-left: 450px;">
               <a href="index.aspx" style="color: black">
                        <i class="fa fa-arrow-left" aria-hidden="true"></i>Continue Shopping
                    </a>
            </div>
        </div>
        </div>
    </section>
</asp:Content>
