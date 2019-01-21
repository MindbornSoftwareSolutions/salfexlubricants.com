<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
	CodeBehind="UpdateRates.aspx.cs" Inherits="Admin.UpdateRates" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div style="display: inline-block">
		<pre class="">Specify rate in following format
250gm=20
500gm=40</pre>
	</div>
	<br />
	<div class="container-fluid">
		<div class="row">
			<asp:Repeater runat="server" ID="repeater1">
				<ItemTemplate>
					<div class="col-md-4 bor">
							<img alt="<%#Eval("name") %>" height="64px" src="/Images/Items/<%#Eval("iid") %>.jpg" /><br />
							<%#Eval("name") %><br />
							<textarea rows="3" cols="30" name="ta_<%#Eval("iid") %>"><%#Eval("rates") %></textarea><br />
							In stock <input type="checkbox" name="is_<%#Eval("iid") %>" <%# "1".Equals(Convert.ToString(Eval("status")))?"checked":"" %> />
							<hr />
					</div>
				</ItemTemplate>
			</asp:Repeater>
		</div>
	</div>
	<asp:Button Text="Update Rates" runat="server" OnClick="Unnamed1_Click" />
</asp:Content>
