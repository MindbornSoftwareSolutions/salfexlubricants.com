<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="EditItem.aspx.cs" Inherits="OVSWeb.Admin.EditItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="0" cellspacing="0">
	
		<tr>
			<td>
				Category
			</td>
			<td>
				<asp:DropDownList runat="server" ID="dd_category">
					<asp:ListItem Text="Vegetables" Value="1" />
					<asp:ListItem Text="Fruits" Value="2" />
					<asp:ListItem Text="Milk Products" Value="3" />
				</asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td>
				Name
			</td>
			<td>
				<asp:TextBox runat="server" ID="tb_name" />
			</td>
		</tr>
		<tr>
			<td>
				Altername Name
			</td>
			<td>
				<asp:TextBox runat="server" ID="tb_altname" />
			</td>
		</tr>
		<tr>
			<td>
				Description
			</td>
			<td>
				<asp:TextBox runat="server" ID="tb_description" TextMode="MultiLine" />
			</td>
		</tr>
		<tr>
			<td>
				Rates
			</td>
			<td>
				<asp:TextBox runat="server" ID="tb_rates" TextMode="MultiLine" />
				<div style="display:inline-block">
				<pre class="">e.g.
250gm=20
500gm=40</pre>
</div>
			</td>
		</tr>
		<tr>
			<td>
				Image
			</td>
			<td>
				<asp:FileUpload ID="FileUpload1" runat="server" />
			</td>
		</tr>
		<tr>
			<td>
				<asp:Button Text="Save" ID="Button1" runat="server" onclick="Button1_Click" />
				<asp:Button Text="Back" ID="Button2" runat="server" onclick="Button2_Click" />
			</td>
		</tr>
	</table>
</asp:Content>
