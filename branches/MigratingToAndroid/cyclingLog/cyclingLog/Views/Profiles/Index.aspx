<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<List<ProfileModel>>" MasterPageFile="~/Views/Shared/NonAuth.Master" %>
<%@ Import Namespace="cyclingLog.Models" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="head">
<title>list of Rider profiles</title>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <%Html.RenderPartial("ProfileGridView",Model); %>
</asp:Content>
