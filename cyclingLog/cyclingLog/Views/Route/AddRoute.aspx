<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<DomainModels.Route>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent"></asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <div>New Route</div>
    <%=Html.Partial("AddUpdateRoute", Model)%>
</asp:Content>