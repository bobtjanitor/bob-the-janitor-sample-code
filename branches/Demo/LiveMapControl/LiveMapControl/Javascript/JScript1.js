<script type="text/javascript" src="http://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=6.2"></script>
      <script type="text/javascript">
      var map = null;
            
      function GetMap()
      {
         map = new VEMap('myMap');
         map.LoadMap();
      }
      
      function DoZoomIn(c)
      {
         map.ZoomIn();
      }
    
      function DoZoomOut()
      {
         map.ZoomOut();
      }
    
      function DoCenterZoom()
      {
         var lat =  document.getElementById('txtMapLat').value;
         var lon =  document.getElementById('txtMapLon').value;
         var zoom = document.getElementById('zoomLevel').value;
         map.SetCenterAndZoom(new VELatLong(lat, lon), zoom);
      }
      </script>
