<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<List<string>>"  MasterPageFile="~/Views/Shared/NonAuth.Master" %>


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
                <td rowspan="5">
                    <ul>
                        <% if (Model!=null)
                        {	
                             foreach (string error in Model)
                             {
                                %><li><%=error %></li><%
                             }  
                        }
                        %>
                    </ul>
                </td>
            </tr>
            <tr>
                <td class="formLabel">
                    Username:
                </td>
                <td>
                    <%=Html.TextBox("Username") %>
                </td>
            </tr>
            <tr>
                <td class="formLabel">
                    password:
                </td>
                <td>
                    <%=Html.Password("PassWord") %>
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
