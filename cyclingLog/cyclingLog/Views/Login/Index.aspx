<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" MasterPageFile="~/Views/Shared/NonAuth.Master" %>


<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <% using (Html.BeginForm("Login", "Login"))
       {
           Html.AntiForgeryToken();
    %>
        <table>
            <tr>
                <th colspan="2">
                    Logon
                </th>
            </tr>
            <tr>
                <td class="formLabel">
                    Username:
                </td>
                <td>
                    <input id="textInput" type="text"/>
                </td>
            </tr>
            <tr>
                <td class="formLabel">
                    password:
                </td>
                <td>
                    <input id="textPassword" type="password"/>
                </td>
            </tr>
            <tr>
                <td colspan="2"><input id="buttonSubmit" type="submit" value="Login"/></td>
            </tr>
        </table>
    <%
       }
    %>
</asp:Content>
