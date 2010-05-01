<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<cyclingLog.Models.RouteModel>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
      <script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2"></script>
      <script type="text/javascript">
          var map = null;

          function GetMap() {
              map = new VEMap('myMap');
              map.LoadMap();
          }   
      </script>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
Content to come
<div id='myMap' style="position:relative; width:400px; height:400px;"></div>
<script type="text/javascript">
    GetMap();
</script>
</asp:Content>
