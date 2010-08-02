<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<DomainModels.Route>" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="DomainModels" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent"></asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
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
            <td colspan="2"><input type="submit" value="Save Route" /></td>
        </tr>
    </table>
    <%
      }
        if(ViewData["IsUpdate"]!=null )
        {
            %>
            <script type="text/javascript">
                var coordinateForms = {};
            </script>
            <div>Add Route Points</div>
            <div>
                <table id="RoutePointsTable">
                    <tr>
                        <td>Lat</td>
                        <td>Lon</td>
                    </tr>
                    <%                     
                    foreach (LatLonCoordinate coordinate in Model.RouteCoordinates)
                    {
                        %>
                        <tr>
                            <td><%=coordinate.Lat%></td>
                            <td><%=coordinate.Lon%></td>
                        </tr>
                        <%                        
                    } 
                %>
                </table>
                <div>Lat: <input id="newLat" type="text" /></div>
                <div>Lon: <input id="newLon" type="text" /></div>
                <input type="button" value="Add" onclick="AddRouteCoordinate($('#newLat')[0].value,$('#newLon')[0].value )" />
            </div>

            <%
        }
    %>
    <script type ="text/javascript">
        $(document).ready(
        function () {
            var routeId = '<%=Model.Id %>';
        }
        )

        function AddRouteCoordinate(lat, lon) {

            $.ajax(
            {
                type: "POST",
                url: "/RouteService.svc/AddCord",
                data: {"lat":lat, "lon":lon, "id":id },

            })
            var ratesTable = $("#RoutePointsTable").get()[0];
            var rowCount = ratesTable.rows.length;
            var row = ratesTable.insertRow(rowCount);

            var latCell = row.insertCell(0);
            latCell.innerHTML = lat;

            var lonCell = row.insertCell(1);
            lonCell.innerHTML = lon;
        }
    </script>
</asp:Content>
