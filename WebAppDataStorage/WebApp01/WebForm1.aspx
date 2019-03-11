<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    <br />
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                  <table>
                      <tr><td>ID</td>
                          <td>NAME</td>
                      </tr>
            </HeaderTemplate>
            <ItemTemplate>
                  
           <tr><td>
               <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label> </td>
               <td>
               <asp:Label ID="Label2" runat="server" Text='<%# Eval("NAME") %>'></asp:Label> </td>
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
