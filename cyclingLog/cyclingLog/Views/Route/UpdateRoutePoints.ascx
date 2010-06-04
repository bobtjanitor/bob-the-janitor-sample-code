<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<System.Collections.Generic.IList<DomainModels.LatLonCoordinate>>" %>
<%@ Import Namespace="DomainModels" %>
<% 
    foreach (LatLonCoordinate coordinate in Model)
    {
        %>
        <form id="coordinateForm" action="<%=Url.Action("UpdateCoordinate")) %>" >
        </form>
        <%
    } 
%>
