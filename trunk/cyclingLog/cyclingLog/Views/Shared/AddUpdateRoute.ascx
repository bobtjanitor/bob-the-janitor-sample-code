<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<DomainModels.Route>" %>
   <%using (Html.BeginForm("UpdateRoute", "Route"))
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
