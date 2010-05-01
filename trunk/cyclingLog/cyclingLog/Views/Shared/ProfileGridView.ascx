<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IList<cyclingLog.Models.ProfileModel>>" %>
<div id="grid" style="width:100%;">
    <h3>Riders</h3>
    <table  width="100%">
        <tr>
            <th>Name</th>
            <th>Location</th>
            <th>Description</th>
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
                    <td><%=Html.ActionLink(Model[x].Name, "/Detail/" + Model[x].Id, "Profiles")%></td>
                    <td><%=Html.ActionLink(Model[x].Location, "/Detail/" + Model[x].Id, "Profiles")%></td>
                    <td><%=Html.ActionLink(Model[x].Description, "/Detail/" + Model[x].Id, "Profiles")%></td>
                </tr>
                <%
            }
        %>
    </table>
</div>

