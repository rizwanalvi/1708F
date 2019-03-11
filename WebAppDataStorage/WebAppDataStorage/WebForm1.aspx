<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppDataStorage.WebForm1" UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Login </h1>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" OnAuthenticate="OnAuthetication" Width="246px">
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
