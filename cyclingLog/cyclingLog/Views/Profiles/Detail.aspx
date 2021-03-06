<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<cyclingLog.Models.ProfileModel>" MasterPageFile="~/Views/Shared/NonAuth.Master" %>
<asp:Content runat="server" ID="Content" ContentPlaceHolderID="head">
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
        <img src="http://s3.amazonaws.com/URodeProfileImages/<%=Model.Id %>.jpg" alt="Profile Image" />
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
<%Html.RenderPartial("RouteGridView",Model.RouteList); %>
<%=Html.ActionLink("[Add Route]","AddRoute","Route") %>
</asp:Content>
