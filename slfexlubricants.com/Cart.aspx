<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="slfexlubricants.com.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin: 15px; padding: 5px; background-color: #fff8a0; border: 1px solid black; border-radius: 10px; box-shadow: 10px 10px 8px #aaaaaa;">
        <h1>Cart</h1>

        <asp:Repeater runat="server" ID="Repeater_CartItems">
            <ItemTemplate>
                <div class="card" style="background-color: #ffffff; border: 1px solid black; border-radius: 5px; margin: 15px; padding: 5px; display: inline-block; max-width: 300px">
                    <img src="Images/<%# ((Object[])Container.DataItem)[0] %>.jpg" style="float: right; max-height: 240px" />
                    <h2><span style="background-color: #b01313; color: #ffffff; padding: 2px 10px 2px 10px; border-radius: 10px"><%# ((Object[])Container.DataItem)[1] %></span> <%# ((Object[])Container.DataItem)[2] %></h2>
                    <%--  <h5 class="card-header"><%#Eval("name") %></h5>--%>
                    <div class="card-body">
                        <%--    <h5 class="card-title"><%#Eval("subname") %></h5>--%>
                        Quantity
                        <asp:DropDownList runat="server">
                            <asp:ListItem Text="1" />
                            <asp:ListItem Text="2" />
                            <asp:ListItem Text="3" />
                            <asp:ListItem Text="4" />
                            <asp:ListItem Text="5" />
                        </asp:DropDownList>
                        <br />
                        <br />
                        <%--<a href="/RemoveFromCart.aspx?id=<%# ((Object[])Container.DataItem)[0] %>" class="btn btn-danger">&times; Remove From Cart</a>--%>
                        <a href="/RemoveFromCart.aspx?id=<%# Container.ItemIndex %>" class="btn btn-danger">&times; Remove From Cart</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <div style="background-color: #ffffff; margin: 15px; padding: 5px; border: 1px solid black; border-radius: 10px; box-shadow: 10px 10px 8px #aaaaaa">
        <h4>Choose Delivery Address</h4>

        <div class="input-group mb-3">
            Name <asp:TextBox runat="server" ID="tb_name" CssClass="input-group"/>
        </div>

        <div class="input-group mb-3">
            Address <asp:TextBox runat="server" ID="tb_address" CssClass="input-group" TextMode="MultiLine" Rows="5" Columns="50" />
        </div>

        <div class="input-group mb-3">
            Contact <asp:TextBox runat="server" CssClass="input-group" ID="tb_contact" TextMode="Phone" />
        </div>

        <div class="input-group mb-3">
            Email<asp:TextBox runat="server" CssClass="input-group" ID="tb_email" TextMode="Email"/>
        </div>

        <button class="btn btn-success">Place Order</button>
        <a href="BrowseProducts">Continue Shopping</a>
    </div>

</asp:Content>
