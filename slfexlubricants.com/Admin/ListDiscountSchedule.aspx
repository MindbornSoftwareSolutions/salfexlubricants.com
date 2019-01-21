<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="ListDiscountSchedule.aspx.cs" Inherits="OVSWeb.Admin.ListDiscountSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:GridView runat="server" ID="GridViewDiscountSchedule" AutoGenerateColumns="false"
		CssClass="table table-responsive" OnRowCommand="GridViewDiscountSchedule_RowCommand"
		DataKeyNames="sid">
		<EmptyDataTemplate>
			<div class="alert alert-info">
				No discount schedule defined</div>
		</EmptyDataTemplate>
		<Columns>
			<asp:TemplateField HeaderText="Start Date">
				<ItemTemplate>
					<%# ((DateTime)Eval("startdate")).ToString("dd-MMM-yyyy") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:TemplateField HeaderText="End Date">
				<ItemTemplate>
					<%# ((DateTime)Eval("enddate")).ToString("dd-MMM-yyyy") %>
				</ItemTemplate>
			</asp:TemplateField>
			<asp:BoundField HeaderText="Title" DataField="title" />
			<asp:BoundField HeaderText="Discount Percent" DataField="discount" />
			<asp:TemplateField>
				<ItemTemplate>
					<asp:Button ID="Button1" runat="server" CommandName="Remove" OnClientClick="return confirm('Delete Schedule?');"
						Text="Delete" CssClass="btn btn-danger" CommandArgument='<%#Eval("sid") %>' />
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
	<br />
	<div class="form-group col-md-4 col-sm-12">
		<table border="0" cellpadding="0" cellspacing="0">
			<tr>
				<td>
					Start Date
				</td>
				<td>
					<asp:TextBox runat="server" ID="startdate" CssClass="form-control" />(dd/mm/yyyy)
				</td>
			</tr>
			<tr>
				<td>
					End Date
				</td>
				<td>
					<asp:TextBox runat="server" ID="enddate" CssClass="form-control" />(dd/mm/yyyy)
				</td>
			</tr>
			<tr>
				<td>
					Title
				</td>
				<td>
					<asp:TextBox runat="server" ID="title" CssClass="form-control" />
				</td>
			</tr>
			<tr>
				<td>
					Discount
				</td>
				<td>
					<asp:TextBox runat="server" ID="discount" CssClass="form-control" />
				</td>
			</tr>
		</table>
		<asp:Button Text="Add New Schedule" runat="server" OnClick="OnAddSchedule" CssClass="btn btn-success" />
	</div>
</asp:Content>
