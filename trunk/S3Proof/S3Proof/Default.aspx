<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="S3Proof.S3Images" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="DivlistOfImages" runat="server" enableviewstate="false">
        
    </div>
    <div style="width:300px; border: 2px solid black; "></div>
    <div>
        <p>Upload image</p>
        <asp:FileUpload ID="imageUpload" runat="server" />
        <asp:Button ID="buttonuploadImage" runat="server" Text="Upload Image" OnClick="buttonuploadImage_click" />
    </div>
    </form>
</body>
</html>
