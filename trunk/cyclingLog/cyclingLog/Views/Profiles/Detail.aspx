<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<cyclingLog.Models.ProfileModel>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="headerContent">
<style type="text/css">
    td.lable
    {
        text-align:right;
        font-size:12px;
        font-weight:bold;
    }
</style>
</asp:Content>
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
<div>
    <div style="float:left">
        <img src="/images/mountain-biking.jpg" alt="Profile Image" />
    </div>
    <div style="float:left">
        <table>
            <tr>
                <td class="lable">Name</td>
                <td><%=Model.Name %></td>
            </tr>
            <tr>
                <td class="lable">Location</td>
                <td><%=Model.Location %></td>
            </tr>
            <tr>
                <td class="lable">Description</td>
                <td><%=Model.Description %></td>
            </tr>            
        </table>
    </div>
    <br style="clear:both" />
</div>
<div id="grid" style="width:100%;">
    <h3>Routes</h3>
    <table  width="100%">
        <tr>
            <th>Name</th>
            <th>Location</th>
            <th>Length</th>
            <th>Last Time Ridden</th>
        </tr>
        <%
            for(int x=0;x<Model.RouteList.Count;x++) 
            {
                string rowStyle = "gridRow";
                if (x%2==0)
                {
                    rowStyle = "gridRowAlt";
                }
                %>
                <tr class="<%=rowStyle %>">
                    <td><%=Model.RouteList[x].Name%></td>
                    <td><%=Model.RouteList[x].Location%></td>
                    <td><%=Model.RouteList[x].Distance%></td>
                    <td><%=Model.RouteList[x].LastTimeRidden%></td>
                </tr>
                <%
            }
        %>
    </table>
</div>
</asp:Content>
