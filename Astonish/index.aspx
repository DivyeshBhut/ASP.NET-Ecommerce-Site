<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Astonish.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Header -->


    <!-- Page Content -->
    <!-- Banner Starts Here -->
    <div class="banner header-text">
        <div class="">
            <div class="banner-item-01">
                <div class="text-content">
                    <h4>Hey
                        <asp:Label ID="lblUserNameHeroSec" runat="server" Text=""></asp:Label>!</h4>
                    <h2>An invisible, sweat & water-resistant sunscreen<br />
                        that leaves absolutely 0 white cast on application.
          <br />
                        It’s a lightweight, moisturizing, antioxidant-rich SPF<br />
                        with very effective UV filters to
          provide<br />
                        protection from UVA & UVB rays.</h2>
                    <button class="btn btn-dark" style="margin-top: 15px;">
                        <asp:LinkButton ID="linkbtnShopNow" runat="server" Style="color: white;" OnClick="linkbtnShopNow_Click">Shop Now</asp:LinkButton>
                    </button>
                </div>
            </div>
        </div>
    </div>
    <!-- Banner Ends Here -->

    <div class="latest-products">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">
                        <h2>Featured Products</h2>
                        <%--<a href="products.html">view more <i class="fa fa-angle-right"></i></a>--%>
                        <asp:LinkButton ID="linkbtnFeatureProduct" runat="server" OnClick="linkbtnFeatureProduct_Click">view more <i class="fa fa-angle-right"></i></asp:LinkButton>
                    </div>
                </div>

                <asp:DataList ID="datalistFeatureProducts" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <%--<div class="col-md-4">--%>
                        <div class="product-item" style="margin: 15px">
                            <a href='<%# "product_details.aspx?ProductId=" + Eval("p_id") %>'>
                                <img src='<%# Eval("p_img") %>' alt='<%# Eval("p_name") %>'/></a>
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

    <div class="best-features">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">
                        <h2>About Us</h2>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="left-content">
                        <p style="font-size: 14px;">
                            Founded in 2023 with the belief that beauty industry requires a revolution with
            respect to TRANSPARENCY. There is lot of inaccurate advice & incorrect claims being made by beauty brands
            which results in fear mongering,
                            <br>
                            misconceptions and eventually consumers making wrong decisions.
                        </p>

                        <p style="font-weight: 500; font-size: 16px; color: black;">
                            "Everything is a chemical – water is a chemical –
            therefore,<br />
                            chemical-free products don’t exist."
                        </p>

                        <h3 style="text-align: center;">HideNothing.</h3>
                        <br>
                        <p style="font-size: 14px;">
                            We wanted to address this issue of lack of transparency through a range of
            products that are straightforward, honest and do what they claim to do. No unnecessary marketing fluff. And
            this is how Astonish was born.
                        </p>
                        <asp:LinkButton class="filled-button" ID="linkbtnAboutUsIndex" runat="server" OnClick="linkbtnAboutUsIndex_Click">Read More</asp:LinkButton>
                        <%--<a href="about-us.html" class="filled-button">Read More</a>--%>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="right-image">
                        <img src="assets/images/about-1-570x350.jpg" alt="">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="services" style="background-image: url(assets/images/other-image-fullscren-1-1920x900.jpg);">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">
                        <h2>Shop by concern</h2>
                        <asp:LinkButton ID="linkbtnHappyClient" runat="server" OnClick="linkbtnHappyClient_Click">read more <i class="fa fa-angle-right"></i></asp:LinkButton>
                        <%--<a href="blog.html">read more <i class="fa fa-angle-right"></i></a>--%>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6">
                    <div class="service-item">
                        <a href="all_products.aspx" class="services-item-image">
                            <img src="assets/images/blog-1-370x270.jpg"
                                class="img-fluid" alt=""></a>
                        <div class="down-content">
                            <h3><a href="all_products.aspx" style="color: black;">Cleanse</a></h3>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6">
                    <div class="service-item">
                        <a href="all_products.aspx" class="services-item-image">
                            <img src="assets/images/blog-2-370x270.jpg" class="img-fluid"
                                alt=""></a>
                        <div class="down-content">
                            <h3><a href="all_products.aspx" style="color: black;">Treat</a></h3>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4 col-md-6">
                    <div class="service-item">
                        <a href="all_products.aspx" class="services-item-image">
                            <img src="assets/images/blog-3-370x270.jpg"
                                class="img-fluid" alt=""></a>
                        <div class="down-content">
                            <h3><a href="all_products.aspx" style="color: black;">Protect</a></h3>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="happy-clients">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">
                        <h2>Happy Clients</h2>
                        
                    </div>
                </div>

                <div class="col-md-12">
                    <div class="owl-clients owl-carousel text-center">
                        <asp:DataList ID="DataListTestimonail" runat="server" RepeatColumns="1">
                            <ItemTemplate>
                                <div class="service-item">
                                    <div class="icon">
                                        <i class="fa fa-user"></i>
                                    </div>
                                    <div class="down-content">
                                        <h4><%# Eval("name") %></h4>
                                        <p class="n-m"><em><%# Eval("testimonial_data") %></em></p>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="call-to-action">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="inner-content">
                        <div class="row">
                            <div class="col-md-8">
                                <h4>Astonish</h4>
                                <p>We are self care products brand , our products helps you to work against your concern.</p>
                            </div>
                            <div class="col-lg-4 col-md-6 text-right">
                                <asp:LinkButton ID="linkbtnContactUsIndex" class="filled-button" runat="server" OnClick="linkbtnContactUsIndex_Click">Contact Us</asp:LinkButton>
                                <%--<a href="contact.html" class="filled-button">Contact Us</a>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- footer section -->
</asp:Content>
