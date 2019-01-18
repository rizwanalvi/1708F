<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppMobile.Default" UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server" >
    <div class="container bg-warning">
     <div class="form-group">
    <label for="txtName">Mobile Name</label>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*RequiredField" ControlToValidate="txtName"  CssClass="alert-danger" Font-Size="Smaller"></asp:RequiredFieldValidator>

         <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
  </div>
          <div class="form-group">
    <label for="txtModel">Mobile Model</label>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*RequiredField" ControlToValidate="txtModel"  CssClass="alert-danger" Font-Size="Smaller"></asp:RequiredFieldValidator>

         <asp:TextBox ID="txtModel" runat="server" CssClass="form-control"></asp:TextBox>

  </div>
          <div class="form-group">
    <label for="lstBrands">Brand Name</label>
              <asp:DropDownList ID="lstBrands" runat="server" CssClass="form-control">
                  <asp:ListItem>NOKIA</asp:ListItem>
                  <asp:ListItem>SAMSUNG</asp:ListItem>
                  <asp:ListItem>APPLE</asp:ListItem>

              </asp:DropDownList>
  </div>
        <div class="form-group">
    <label for="txtModel">Upload Image</label>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*RequiredField" ControlToValidate="FileUpload1"  CssClass="alert-danger" Font-Size="Smaller"></asp:RequiredFieldValidator>
         
               <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control-file" />

  </div>
        <div class="form-group"> 
        <asp:Button ID="Button1" runat="server" Text="Add" Width="80px" CssClass="btn btn-success" OnClick="Button1_Click"/>
<div>
   <br />
</div>

            </div>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="NAME" HeaderText="MOBILE NAME" />
                    <asp:ImageField DataImageUrlField="IMGPATH" HeaderText="IMAGE" ControlStyle-CssClass="img-thumbnail" ControlStyle-Height="50px" ControlStyle-Width="50px">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </div>

    
    </form>
</body>
</html>
