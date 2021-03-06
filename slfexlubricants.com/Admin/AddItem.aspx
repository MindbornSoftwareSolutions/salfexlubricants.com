﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="AddItem.aspx.cs" Inherits="Admin.AddItem" %>

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
			<td>
				Sub Name
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
				Rate
			</td>
			<td>
				<asp:TextBox runat="server" ID="tb_rates" />
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
				<asp:Button Text="Add" ID="Button1" runat="server" onclick="Button1_Click" />
				<asp:Button Text="Back" ID="Button2" runat="server" onclick="Button2_Click" />
			</td>
		</tr>
	</table>
</asp:Content>
