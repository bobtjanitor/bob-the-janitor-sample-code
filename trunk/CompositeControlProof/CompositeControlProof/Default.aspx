<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CompositeControlProof._Default" %>
<%@ Register Assembly="UserControls" TagPrefix="UC" Namespace="UserControls"  %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        div.Menu
        {
            width:100px;            
        }
        
        div.MenuItem
        {
            border:solid 1px gray;
            margin:3px 3px 3px 3px;
            padding:3px 3px 3px 3px;
            color:Black;
            font-weight:500;  
            width:100%;  
            background-color:#DEEAF9;        
        }
        div.MenuItem:hover 
        {
            font-weight:900;
        }
        div.MenuItemSelected
        {
            border:solid 1px gray;
            margin:3px 3px 3px 3px;
            padding:3px 3px 3px 3px;
            color:Black;
            width:100%;  
            background-color:#DEEAF9; 
            font-weight:900;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <UC:MenuControl ID="menuControl1" runat="server" >
            <MenuItems>
                <UC:MenuItemControl id="myItem1" runat="server" Selected="true" LinkURL="http://google.com" Text="to Google"></UC:MenuItemControl>
                <UC:MenuItemControl id="myItem2" runat="server" LinkURL="http://bing.com" Text="to Bing"></UC:MenuItemControl>
                <UC:MenuItemControl id="myItem3" runat="server" LinkURL="http://yahoo.com" Text="to Yahoo"></UC:MenuItemControl>                                
                <UC:MenuItemControl id="myItem4" LinkURL="http://msn.com" runat="server" Text="to msn"></UC:MenuItemControl>                                
            </MenuItems>            
        </UC:MenuControl>
    </form>
</body>
</html>
