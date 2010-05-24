<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<DomainModels.Route>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent"></asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <div>New Route</div>
    <%using (Html.BeginForm("AddRoute", "Route"))
      {
          %>
          <%=Html.AntiForgeryToken() %>
          <%=Html.Hidden("Id", Model.Id) %>
    <table>
        <tr>
            <td>Route Name:</td>
            <td><%=Html.TextBox("Name")%></td>
        </tr>
        <tr>
            <td>Location:</td>
            <td><%=Html.TextBox("Location")%></td>
        </tr>
        <tr>
            <td colspan="2"><input type="submit" value="Add Route" /></td>
        </tr>
    </table>
    <%
      }%>
</asp:Content>
