<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="ListItem.aspx.cs" Inherits="OVSWeb.Admin.ListItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:Label Text="" ID="l_category" runat="server" />
	<br />
	<asp:LinkButton class="btn btn-success" ID="LinkButton2" runat="server" OnClick="LinkButton1_Click">Add New Item</asp:LinkButton>
	<div class="container-fluid">
		<div class="row">
			<asp:Repeater ID="Repeater1" runat="server" DataMember="iid" OnItemCommand="Repeater1_ItemCommand">
				<HeaderTemplate>
				</HeaderTemplate>
				<ItemTemplate>
					<div class="col-lg-3 col-md-3 col-sm-4 cols-xs-12 well" style="height: 400px; padding: 5px">
						<h4>
							<%#Eval("name") %></h4>
						<%#Eval("altname") %><br />
						<%#Eval("description") %><br />
						<%--<img alt="<%#Eval("name") %>" height="100px" src="/Image.ashx?iid=<%#Eval("iid") %>" /><br />--%>
						<img alt="<%#Eval("name") %>" height="100px" src="/Images/Items/<%#Eval("iid") %>.jpg" /><br />
						Rates:<br />
						<%#Eval("rates").ToString().Replace("\r\n","<br/>") %>
						<br />
						<asp:Button ID="Button1" CssClass="btn btn-primary" Text="Edit Item" CommandName="EditItem"
							CommandArgument='<%#Eval("iid") %>' runat="server" />
						<asp:Button ID="Button2" CssClass="btn btn-danger" Text="Remove Item" CommandName="RemoveItem"
							CommandArgument="<%#Container.DataItem %>" runat="server" OnClientClick="return confirm('Do you want to remove this item?');" />
						<hr />
					</div>
				</ItemTemplate>
				<FooterTemplate>
					<hr />
				</FooterTemplate>
			</asp:Repeater>
		</div>
	</div>
	<br />
	<br />
	<asp:LinkButton class="btn btn-success" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Add New Item</asp:LinkButton>
</asp:Content>
