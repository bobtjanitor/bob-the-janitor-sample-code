<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<cyclingLog.Models.RouteModel>" MasterPageFile="~/Views/Shared/NonAuth.Master" %>
<%@ Import Namespace="cyclingLog.Views.Route" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="head">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2"></script>
      <script type="text/javascript">
          var map = null;
          var center = new VELatLong(43.62027442738427, -116.65758691728115);


          function GetMap() {
              map = new VEMap('myMap');
              map.HideDashboard();
              map.LoadMap(center, 14, VEMapStyle.Road, false, VEMapMode.Mode2D, true, 1);
              //AddPin();
              AddRoute();

          }

          function AddRoute() {
          <%=Html.AddRouteToMap("map", Model.RouteCoordinates)%>
             
          }  

         function AddPin()
         {
            // Add a new pushpin to the center of the map.
            pinPoint = new VELatLong(43.627680,-116.667486)
            pinPixel = map.LatLongToPixel(pinPoint);
            map.AddPushpin(pinPoint);
         }

      </script>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
<div id='myMap' style="position:relative; width:400px; height:400px;"></div>
<script type="text/javascript">
    GetMap();
</script>
</asp:Content>
