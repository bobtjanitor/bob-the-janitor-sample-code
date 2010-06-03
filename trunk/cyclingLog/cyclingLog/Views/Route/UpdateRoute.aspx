<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<DomainModels.Route>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent"></asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <%=Html.Partial("AddUpdateRoute", Model)%>
    <%=Html.Partial("Errors",new List<string>())%>
</asp:Content>
