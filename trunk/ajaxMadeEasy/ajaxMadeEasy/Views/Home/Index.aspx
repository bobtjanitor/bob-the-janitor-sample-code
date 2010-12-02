<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<ajaxMadeEasy.Models.UserModel>" MasterPageFile="~/Views/Shared/Site.Master" %>
<%@ Import Namespace="ajaxMadeEasy.Controllers" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">

    <select name="SelectUserType" onchange="UpdateUserType(this,<%=Model.UserId%>)">
        <%foreach (UserTypes item in Enum.GetValues(typeof(UserTypes)).Cast<UserTypes>())
        {
                if(item ==  Model.Type)
                {
                    %><option selected="selected" value="<%=((int)item).ToString() %>"><%=item.ToString() %></option><%
                }
                else
                {
                    %><option value="<%=((int)item).ToString() %>"><%=item.ToString() %></option><%
                }
        } %>
    </select>

    <script type="text/javascript">
        function UpdateUserType(sender, userId) {
            var model = { UserId: userId, Type: sender.value };
            $.post("/home/UpdateUserType",
                model,
               function (data) {

                   alert("Was SuccessFul: " + data.Succss);
                   alert("Message: " + data.Message);
               });
        }
    </script>
</asp:Content>
