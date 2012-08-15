<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<IList<cyclingLog.Models.RouteModel>>" MasterPageFile="~/Views/Shared/NonAuth.Master" %>
<asp:Content runat="server" ID="Head" ContentPlaceHolderID="head"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <%Html.RenderPartial("RouteGridView",Model); %>
</asp:Content>
