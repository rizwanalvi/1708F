<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApp01.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Server Control" OnClick="Button1_Click" CssClass="btn btn-warning"/>
        <input id="Button2" type="button" value="Html Control" /></div>
        <input type="button" name="name" value="Html Server Control" runat="server" />
        <br />
        <asp:ListBox ID="lstFruit" runat="server"  Width="100%" OnSelectedIndexChanged="lstFruit_SelectedIndexChanged" AutoPostBack="True" CssClass="list-group" ForeColor="Brown"></asp:ListBox>
   <hr/>
        <div class="bg bg-info">
           
        <asp:Image ID="imgFruit" runat="server" ImageUrl="~/img/01.jpg" CssClass="border border-secondary rounded"  Height="100px" Width="100px" />
        <asp:Label ID="lblFruitName" runat="server" Text="Label" Font-Size="Medium" Font-Bold="true"></asp:Label>
             </div>
        
         </form>
</body>
</html>
