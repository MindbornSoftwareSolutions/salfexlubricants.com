<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="ManageOrders.aspx.cs" Inherits="Admin.ManageOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<span class="label label-info">Choose Order Status</span>
	<asp:DropDownList runat="server" AutoPostBack="True" 
	ID="dd_orderstatus"
		onselectedindexchanged="Unnamed1_SelectedIndexChanged"		
		>
		<asp:ListItem Text="Placed" Value="Placed" />
		<asp:ListItem Text="Accepted" Value="Accepted" />
		<asp:ListItem Text="Dispatched" Value="Dispatched" />
		<asp:ListItem Text="Delivered" Value="Delivered" />
		<asp:ListItem Text="Rejected" Value="Rejected" />
	</asp:DropDownList>
	<asp:GridView ID="GridView1" runat="server" class="table1 table-responsive1" AutoGenerateColumns="false"
		DataKeyNames="oid" OnRowCommand="GridView1_RowCommand"
		PagerSettings-Visible="true" PageSize="10" AllowPaging="true"
		PagerSettings-Mode="NumericFirstLast" PagerStyle-CssClass="pagination" onpageindexchanging="GridView1_PageIndexChanging"
		>
		<Columns>
			<asp:BoundField HeaderText="Order Id" DataField="oid" />
			<asp:BoundField HeaderText="Date/Time" DataField="datetime" />
			<asp:BoundField HeaderText="Customer" DataField="name" />
			<asp:BoundField HeaderText="Contact" DataField="contact" />
			<asp:BoundField HeaderText="Email" DataField="email" />
			<asp:BoundField HeaderText="Schedule Date" DataField="scheduleddate" />
			<asp:BoundField HeaderText="Amount" DataField="amount" />
			<asp:BoundField HeaderText="Delivery Address" DataField="address" />
			<asp:TemplateField>
				<ItemTemplate>
					<pre style="background: white; border: 0px">
<%#Eval("items") %>
</pre>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField HeaderText="Status" DataField="status" />
			<asp:ButtonField ControlStyle-CssClass="btn btn-default" Text="Accept" CommandName="Accept" />
			<asp:ButtonField ControlStyle-CssClass="btn btn-default" Text="Dispatch" CommandName="Dispatch" />
			<asp:ButtonField ControlStyle-CssClass="btn btn-default" Text="Delivered" CommandName="Delivered" />
			<asp:ButtonField ControlStyle-CssClass="btn btn-danger" Text="Reject" CommandName="Reject" />
			<asp:ButtonField ControlStyle-CssClass="btn btn-danger" Text="Remove" CommandName="Remove" />
		</Columns>
	</asp:GridView>
</asp:Content>
