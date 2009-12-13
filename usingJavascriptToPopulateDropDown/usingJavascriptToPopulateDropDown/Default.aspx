<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usingJavascriptToPopulateDropDown._Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script type="text/javascript" src="dropdown.js"></script>
</head>
<body>
    <form id="form1" runat="server" enableviewstate="false">
    <div>
        <asp:ScriptManager ID="scriptManager" runat="server">
            <Services>
                <asp:ServiceReference Path="/DataService.svc" />
            </Services>
        </asp:ScriptManager>
        <select 
            id="dropDownList" 
            runat="server" 
            enableviewstate="false" 
            style="width:200px;" 
            onfocus="populateDropDown(this);">
        </select>        
        <asp:Button ID="buttonGetValue" runat="server" Text="get value" OnClick="buttonGetValue_Click" />
        
        <asp:Literal ID="output" runat="server"></asp:Literal>
    </div>
    </form>
    
</body>
</html>
