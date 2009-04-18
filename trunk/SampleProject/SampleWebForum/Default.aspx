<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/NonAuthenticated.Master" CodeBehind="Default.aspx.cs" Inherits="SampleWebForum._Default" %>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="LabelCell">User Name</td>
            <td><asp:TextBox ID="TextUserName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="LabelCell">Passowrd</td>
            <td><asp:TextBox ID="TextPassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><asp:ImageButton ID="ButtonLogin" runat="server" ImageUrl="~/Images/Button_Login.png" OnClick="ButtonLogin_Click" /> </td>
        </tr>
        <tr>
            <td><asp:Literal id="LiteralErrors" runat="server"/></td>
        </tr>
    </table>
</asp:Content>
