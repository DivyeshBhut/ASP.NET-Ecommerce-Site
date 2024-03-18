<%@ Page Title="" Language="C#" MasterPageFile="~/Astonish.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="Astonish.checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
        </div>
    </div>

    <div class="products call-to-action">
        <div class="container">
            <ul class="list-group list-group-flush">
                <li class="list-group-item">
                    <div class="row">
                        <div class="col-6">
                            <em>Sub-total</em>
                        </div>

                        <div class="col-6 text-right">
                            <strong>₹<asp:Label ID="lblSubtotal" runat="server" Text=""></asp:Label></strong>
                        </div>
                    </div>
                </li>

                <li class="list-group-item">
                    <div class="row">
                        <div class="col-6">
                            <em>Extra</em>
                        </div>

                        <div class="col-6 text-right">
                            <strong>₹ 0.00</strong>
                        </div>
                    </div>
                </li>

                <li class="list-group-item">
                    <div class="row">
                        <div class="col-6">
                            <em>Tax</em>
                        </div>

                        <div class="col-6 text-right">
                            <strong>₹ 0.00</strong>
                        </div>
                    </div>
                </li>

                <li class="list-group-item">
                    <div class="row">
                        <div class="col-6">
                            <h4><em>Total</em></h4>
                        </div>

                        <div class="col-6 text-right">
                            <h4><strong>₹<asp:Label ID="lblTotal" runat="server" Text=""></asp:Label></strong></h4>
                        </div>
                    </div>
                </li>

            </ul>

            <br>

            <div class="inner-content">
                <div class="contact-form">
                    <asp:HiddenField ID="total" runat="server" Value="1000" />
                    <div class="row">
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="pre_name" Text="Title:" CssClass="control-label"></asp:Label>
                                <asp:DropDownList ID="pre_name" runat="server" CssClass="form-control" required>
                                    <asp:ListItem Text="-- Choose --" Value="" />
                                    <asp:ListItem Text="Mr." Value="mr" />
                                    <asp:ListItem Text="Miss" Value="miss" />
                                    <asp:ListItem Text="Mrs." Value="mrs" />
                                    <asp:ListItem Text="Ms." Value="ms" />
                                    <asp:ListItem Text="Dr." Value="dr" />
                                    <asp:ListItem Text="Other" Value="other" />
                                    <asp:ListItem Text="Prof." Value="prof" />
                                    <asp:ListItem Text="Rev." Value="rev" />
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server" AssociatedControlID="name" Text="Name:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="name" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label3" runat="server" AssociatedControlID="email" Text="Email:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="email" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label4" runat="server" AssociatedControlID="mno" Text="Phone:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="mno" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label5" runat="server" AssociatedControlID="address1" Text="Address 1:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="address1" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label6" runat="server" AssociatedControlID="address2" Text="Address 2:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="address2" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label7" runat="server" AssociatedControlID="city" Text="City:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="city" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label8" runat="server" AssociatedControlID="state" Text="State:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="state" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label9" runat="server" AssociatedControlID="zip" Text="Zip:" CssClass="control-label"></asp:Label>
                                <asp:TextBox ID="zip" runat="server" CssClass="form-control" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label10" runat="server" AssociatedControlID="country" Text="Country:" CssClass="control-label"></asp:Label>
                                <asp:DropDownList ID="country" runat="server" CssClass="form-control" required>
                                    <asp:ListItem Text="India" Value="India" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-6 col-xs-12">
                            <div class="form-group">
                                <asp:Label ID="Label11" runat="server" AssociatedControlID="payment" Text="Payment method:" CssClass="control-label"></asp:Label>
                                <asp:DropDownList ID="payment" runat="server" CssClass="form-control" required>
                                     <asp:ListItem Text="Online Payment" Value="Online Payment" />
                                    <asp:ListItem Text="Cash on delivery" Value="Cash on delivery" />
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:CheckBox ID="chkAgree" runat="server" Text="I agree with the " />
                        <a href="terms.php" target="_blank" style="color: black;">Terms &amp; Conditions</a>
                    </div>

                    <div class="clearfix">
                        <asp:LinkButton ID="btnBack" class="filled-button pull-left" runat="server" OnClick="btnBack_Click">Back</asp:LinkButton>

                        <asp:LinkButton ID="btnFinish" class="filled-button pull-right" runat="server" OnClick="btnFinish_Click">Place Order</asp:LinkButton>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
