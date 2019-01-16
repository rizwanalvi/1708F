<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppEx02.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:1601DASPConnectionString %>" SelectCommand="SELECT * FROM [UN_PROGRAMS]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <table border="1" style="width:100%">
            <tr>
                <td>ID</td>
                <td>NAME</td>
                <td></td>
            </tr>
            </HeaderTemplate>
            <ItemTemplate>
                 <tr>
                     <td><%# Eval("ID") %></td>
                <td><%# Eval("PROG_NAME") %></td>
                       <td>
                           <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" /><asp:Button ID="Button1" runat="server" Text="Update" /></td>
            </tr>
            </ItemTemplate>
            <FooterTemplate>
                 </table>
            </FooterTemplate>
        </asp:Repeater>
        
           
       
    </div>
    </form>
</body>
</html>
