﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        alert("ok");
        var btnClick = document.getElementById("btnClick");
        btnClick.onclick = function() {
           
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" name="name" value="" id="btnClick" />
    </div>
    </form>
</body>
</html>
