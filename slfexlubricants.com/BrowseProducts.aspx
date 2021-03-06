﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BrowseProducts.aspx.cs" Inherits="slfexlubricants.com.BrowseProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Product List</h4>
    <div style="vertical-align: top">
        <asp:Repeater runat="server" ID="Repeater_ItemList">
            <ItemTemplate>

                <a href="ProductDetails?itemid=<%#Eval("itemid") %>">
                    <div class="card" style="background-color: #fdfdfd; border: 1px solid black; border-radius: 5px; margin: 15px; padding: 5px; display: inline-block; max-width: 300px; box-shadow: 7px 7px 12px #dddddd; width: 300px; vertical-align: top; cursor: pointer">
                        <div style="height: 150px; overflow: auto">
                            <%--<img src="Images/<%#Eval("itemid") %>.jpg" style="float: right; max-height: 240px; max-width: 240px; box-sizing: border-box" />--%>
                            <h2><span style="background-color: #b01313; color: #ffffff; padding: 2px 10px 2px 10px; border-radius: 10px"><%#Eval("name") %></span></h2>
                            <h5><%#Eval("subname") %></h5>
                            <%--  <h5 class="card-header"><%#Eval("name") %></h5>--%>
                            <div class="card-body">
                                <%--    <h5 class="card-title"><%#Eval("subname") %></h5>--%>
                                <p class="card-text"><%#Eval("descriptionjson") %></p>
                            </div>
                        </div>
                        <%--<a href="/AddToCart.aspx?id=<%#Eval("itemid") %>" class="btn btn-primary" style="position: relative; bottom: 10px">Add To Cart</a>--%>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
