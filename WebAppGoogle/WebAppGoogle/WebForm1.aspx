<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppGoogle.WebForm1" %>

<%@ Register Assembly="GoogleMaps" Namespace="GoogleMaps" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <cc1:GoogleMap ID="GoogleMap1" runat="server" ApiKey="AIzaSyAk6j9RPAGrJg53hShhz8c16lWB5ENSpbc" MapType="Roadmap"></cc1:GoogleMap>
    
    </div>
    </form>
</body>
</html>
