<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<cyclingLog.Models.RouteModel>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2"></script>
      <script type="text/javascript">
          var map = null;
          var center = new VELatLong(43.62027442738427, -116.65758691728115);


          function GetMap() {
              map = new VEMap('myMap');
              map.HideDashboard();
              map.LoadMap(center, 14, VEMapStyle.Road, false, VEMapMode.Mode2D, true, 1);
              AddPin();
              AddRoute();

          }

          function AddRoute() {
              var route =
              [
                new VELatLong(43.627680, -116.667486),
                new VELatLong(43.62747676670551, -116.66454523801804),
                new VELatLong(43.627808690071106, -116.6630083322525),
                new VELatLong(43.61903250217438, -116.66299760341644),
                new VELatLong(43.61891984939575, -116.67299151420593),
                new VELatLong(43.65262247622013, -116.67316854000092),
                new VELatLong(43.646069169044495, -116.6629010438919),
                new VELatLong(43.62743854522705, -116.66747152805328)
              ]
              map.GetDirections(route);
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
Content to come
<div id='myMap' style="position:relative; width:400px; height:400px;"></div>
<script type="text/javascript">
    GetMap();
</script>
</asp:Content>
