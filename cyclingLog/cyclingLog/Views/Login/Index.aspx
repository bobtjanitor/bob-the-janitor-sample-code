<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .formLabel
        {
            font-weight:bold;
            text-align:right;
        }
    </style>
</head>
<body>
    <%Html.BeginForm("Login","Login"); %>
        <% Html.AntiForgeryToken(); %>
        <table>
            <tr>
                <th colspan="2">
                    Logon
                </th>
            </tr>
            <tr>
                <td class="formLabel">
                    Username:
                </td>
                <td>
                    <input id="textInput" type="text"/>
                </td>
            </tr>
            <tr>
                <td class="formLabel">
                    password:
                </td>
                <td>
                    <input id="textPassword" type="password"/>
                </td>
            </tr>
            <tr>
                <td colspan="2"><input id="buttonSubmit" type="submit" value="Login"/></td>
            </tr>
        </table>
</body>
</html>
