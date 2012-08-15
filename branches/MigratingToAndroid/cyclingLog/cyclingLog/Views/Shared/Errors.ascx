<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<List<string>>" %>
<%if(Model!=null && Model.Count>0)
  {
      %>
        <ul style="color:Red">
            <%
            foreach (string error in Model)
            {
                %>
                <li><%=error %></li>
                <%
            }
            %>
        </ul>
      <%
  } 
%>
