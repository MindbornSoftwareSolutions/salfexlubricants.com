<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="ChangePassword.aspx.cs" Inherits="Admin.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="form-group">
		<div class="input-group">
			Current Password
			<asp:TextBox runat="server" ID="tb_currentpassword" placeholder="Current Password"
				CssClass="form-control" TextMode="Password" />
			<br />
			New Password
			<asp:TextBox runat="server" ID="tb_newpassword" placeholder="New Password" CssClass="form-control" TextMode="Password" />
			<br />
			Confirm Password
			<asp:TextBox runat="server" ID="tb_confirmpassword" placeholder="Current Password"
				CssClass="form-control" TextMode="Password" />
			<br />
			<br />
			<asp:Button Text="Change Password" runat="server" CssClass="btn btn-success" OnClick="Unnamed1_Click" />
			<br />
			<br />
			<asp:Label ID="message" Text="" runat="server" />
		</div>
	</div>
</asp:Content>
