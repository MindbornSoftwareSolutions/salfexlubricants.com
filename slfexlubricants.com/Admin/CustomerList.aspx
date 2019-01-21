<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Admin.CustomerList"
	MasterPageFile="~/Main.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="page-header well">
		<h1>
			Customer List</h1>
	</div>
	<div class="container-fluid">
		<div class="row">
			<div class="col-lg-10">
				<asp:GridView ID="GridView1" runat="server" class="table table-responsive" AllowPaging="true"
					OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="50">
				</asp:GridView>
			</div>
		</div>
	</div>
</asp:Content>
