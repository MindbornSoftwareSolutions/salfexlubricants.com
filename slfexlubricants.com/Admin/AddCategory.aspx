<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="slfexlubricants.com.Admin.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    	<table border="0" cellpadding="0" cellspacing="0" class="table">
		<tr>
			<td>
				Name
			</td>
			<td>
				<asp:TextBox runat="server" ID="tb_name" />
			</td>
		</tr>
            
		<tr>
			<td colspan="2">
				<asp:Button CssClass="btn btn-success" Text="Add" ID="Button1" runat="server" onclick="Button1_Click" />
				<asp:Button CssClass="btn btn-default" Text="Back" ID="Button2" runat="server" onclick="Button2_Click" />
			</td>
		</tr>
	</table>

</asp:Content>
