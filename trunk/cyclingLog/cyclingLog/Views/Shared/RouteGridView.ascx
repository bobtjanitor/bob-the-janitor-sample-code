<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IList<cyclingLog.Models.RouteModel>>" %>
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
            for(int x=0;x<Model.Count;x++) 
            {
                string rowStyle = "gridRow";
                if (x%2==0)
                {
                    rowStyle = "gridRowAlt";
                }
                %>
                <tr class="<%=rowStyle %>">
                    <td><%=Html.ActionLink(Model[x].Name, "/Detail/" + Model[x].Id, "Route")%></td>
                    <td><%=Html.ActionLink(Model[x].Location, "/Detail/" + Model[x].Id, "Route")%></td>
                    <td><%=Html.ActionLink(Model[x].Distance.ToString(), "/Detail/" + Model[x].Id, "Route")%></td>
                    <td><%=Html.ActionLink(Model[x].LastTimeRidden.ToShortDateString(), "/Detail/" + Model[x].Id, "Route")%></td>
                </tr>
                <%
            }
        %>
    </table>
</div>

