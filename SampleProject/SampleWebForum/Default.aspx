<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleWebForum._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
    
    </div>
    </form>
</body>
</html>
