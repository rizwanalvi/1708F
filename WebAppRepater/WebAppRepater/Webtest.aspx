<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webtest.aspx.cs" Inherits="WebAppRepater.Webtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DB1708FConnectionString %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PROID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="PROID" HeaderText="PROID" InsertVisible="False" ReadOnly="True" SortExpression="PROID" />
                <asp:BoundField DataField="PRO_NAME" HeaderText="PRO_NAME" SortExpression="PRO_NAME" />
                <asp:BoundField DataField="BRAND" HeaderText="BRAND" SortExpression="BRAND" />
                <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
                <asp:BoundField DataField="QUANTITY" HeaderText="QUANTITY" SortExpression="QUANTITY" />
                <asp:BoundField DataField="CATID" HeaderText="CATID" SortExpression="CATID" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
              
                 
            </HeaderTemplate>
            <ItemTemplate>
           <div class="card-deck">
        <div class="card">
    <img class="card-img-top" src="..." alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title bg-danger"><%# Eval("PRO_NAME") %></h5>
      <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
      <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
    </div>
  </div>

                    
            
            </ItemTemplate>
            <FooterTemplate>

            </FooterTemplate>
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
