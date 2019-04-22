<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>


        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 74px"></asp:TextBox>

        <br />
        <br />

        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 76px"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" style="margin-left: 48px" />


    </div>
    </form>
</body>
</html>
