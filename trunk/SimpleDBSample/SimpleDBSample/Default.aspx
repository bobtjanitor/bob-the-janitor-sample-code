<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleDBSample._Default" %>

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
                <td>
                    Contact Name
                </td>
                <td>
                    <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email 
                </td>
                <td>
                    <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Phone 
                </td>
                <td>
                    <asp:TextBox ID="TextPhone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="buttonAddContact" Text="Add New Contact" runat="server" OnClick="buttonAddContact_Click" />
                </td>
            </tr>
        </table>
    </div>
    
    <div style="display:none;">
        <table>            
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="buttonShowAllContacts" runat="server" Text="Search" OnClick="buttonShowAll_Click"/>
                </td>
            </tr>
    </table>
    </div>
    <div style="display:none;">
        <table>
            <tr>
                <td>
                       Contact Name:
                </td>
                <td>
                    <asp:TextBox ID="textContactName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="buttonSearch" runat="server" Text="Search" OnClick="buttonSearch_Click"/>
                </td>
            </tr>
    </table>
     </div>
    <asp:DataGrid ID="gridContacts" runat="server" AutoGenerateColumns="true">
        <Columns>
            <asp:BoundColumn DataField="Name" HeaderText="Name"></asp:BoundColumn>
        </Columns>
    </asp:DataGrid>
   
    </form>
</body>
</html>
