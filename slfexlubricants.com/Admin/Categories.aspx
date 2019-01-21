<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="Categories.aspx.cs" Inherits="Admin.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--	<a href="/Admin/ListItem.aspx?cid=1">Vegetables</a><br />
	<a href="/Admin/ListItem.aspx?cid=2">Fruits</a><br />
	<a href="/Admin/ListItem.aspx?cid=3">Milk Products</a><br />--%>

    <asp:Repeater runat="server" ID="repeater_cat">
        <ItemTemplate>
        	<a href="/Admin/ListItem.aspx?cid=<%#Eval("categoryid") %>"><%#Eval("name") %></a><br />
        </ItemTemplate>
    </asp:Repeater>
    <a href="/Admin/AddCategory.aspx" class="btn btn-success">Add New Category</a>
</asp:Content>
