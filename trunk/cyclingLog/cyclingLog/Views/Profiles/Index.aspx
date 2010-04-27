<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<List<ProfileModel>>" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="cyclingLog.Models" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="TitleContent">
list of Rider profiles
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
<table>
    <%
        foreach (ProfileModel profile in Model)
        {
          %>
            <tr>
                <td><%=profile.Name %> </td>
                <td><%=profile.Description %> </td>
            </tr>
          <%
        }
    %>
</table>
</asp:Content>
