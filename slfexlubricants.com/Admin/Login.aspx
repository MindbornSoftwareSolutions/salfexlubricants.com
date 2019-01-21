<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
	Inherits="OVSWeb.Login" %>

<html>
<body>
	<form id="form1" runat="server">
	<p>
		Login</p>
	<table>
		<tr>
			<td style="width: 200px">
				Username
			</td>
			<td>
				<asp:TextBox runat="server" ID="username" />
			</td>
		</tr>
		<tr>
			<td>
				Password
			</td>
			<td>
				<asp:TextBox runat="server" ID="password" TextMode="Password" />
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<asp:Button Text="Login" runat="server" OnClick="OnLogin" />
			</td>
		</tr>
	</table>
	<asp:Label ID="l_error" runat="server" ForeColor="Red"></asp:Label>
	</form>
</body>
</html>
