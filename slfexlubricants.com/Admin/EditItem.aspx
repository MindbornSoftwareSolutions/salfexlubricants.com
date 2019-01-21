<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="EditItem.aspx.cs" Inherits="Admin.EditItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" cellpadding="0" cellspacing="0">

        <tr>
            <td>Category
            </td>
            <td>
                <asp:DropDownList runat="server" ID="dd_category">
                    <%--					<asp:ListItem Text="Vegetables" Value="1" />
					<asp:ListItem Text="Fruits" Value="2" />
					<asp:ListItem Text="Milk Products" Value="3" />--%>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Name
            </td>
            <td>
                <asp:TextBox runat="server" ID="tb_name" />
            </td>
        </tr>
        <tr>
            <td>Altername Name
            </td>
            <td>
                <asp:TextBox runat="server" ID="tb_altname" />
            </td>
        </tr>
        <tr>
            <td>Description
            </td>
            <td>
                <asp:TextBox runat="server" ID="tb_description" TextMode="MultiLine" Rows="5" Columns="80" />
            </td>
        </tr>
        <tr>
            <td>Rate
            </td>
            <td>
                <asp:TextBox runat="server" ID="tb_rates" />
            </td>
        </tr>
        <tr>
            <td>Image
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button Text="Save" ID="Button1" runat="server" OnClick="Button1_Click" />
                <asp:Button Text="Back" ID="Button2" runat="server" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
