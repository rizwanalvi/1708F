<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userreg.aspx.cs" Inherits="userreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

              <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous"/>

</head>
<body>
    <form id="form1" runat="server">
        <br /><br />
    <div class="container bg-light">
        <center> 
            <h1 class="h1 text-info">Registration Form</h1>
   <div class="row pt-5">
                <div class="col">
                    <asp:TextBox ID="TextBox1" class="form-control" placeholder="First name" runat="server" Width="1515px"></asp:TextBox>
            </div>
            <div class="col">
                <asp:TextBox ID="TextBox2" class="form-control" placeholder="Last name" runat="server"></asp:TextBox>
             </div>
  </div><br /><br />
            <div class="row">
                <div class="col-lg-2">
                    <asp:Label ID="Label1"  class="form-check-label h3" runat="server" Text="Gender"></asp:Label>
            </div>
            <div class="col-lg-2">
               <asp:RadioButton ID="RadioButton1" runat="server"></asp:RadioButton> Male  
             </div>
                <div class="col-lg-2">
                <asp:RadioButton ID="RadioButton2" runat="server"></asp:RadioButton>Female 
             </div>
  </div>
             <div class="row pt-5">
                <div class="col">
                    <asp:TextBox ID="TextBox3" class="form-control" placeholder="Contact Number" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Visible="False"></asp:RegularExpressionValidator>
                <asp:TextBox ID="TextBox4" class="form-control" placeholder="E-mail" runat="server"></asp:TextBox>
             </div>
  </div><br />
             <div class="row">
                <div class="col">
                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server"></asp:FileUpload>
                    <p>Address document Image in jpg Format only !</p>
            </div>
            <div class="col">
              <asp:TextBox ID="TextBox5" class="form-control" placeholder="Residential Address" runat="server"></asp:TextBox>
             </div>
  </div>
            <div class="row">
                <div class="col">
                    <asp:TextBox ID="TextBox7" class="form-control" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="col">
              <asp:TextBox ID="TextBox6" class="form-control" placeholder="Confrim Password" runat="server" TextMode="Password"></asp:TextBox>
             </div>
  </div><br />
            <div class="row">                
            <div class="col">
             <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server">
                    <asp:ListItem Value="-1">Select Role</asp:ListItem>
                 <asp:ListItem>EyeWitness</asp:ListItem>
                 <asp:ListItem>Victim</asp:ListItem>
                 </asp:DropDownList>
             </div>
  </div><br />
            <div class="row">
                <div class="col">
                <asp:Button ID="Button1" CssClass="btn btn-primary btn-lg pr-5 pl-5" runat="server" Text="Submit" OnClick="Button1_Click"></asp:Button>
            
            </div>
                </div>
        </center>



    </div>
    </form>
  <!-- Optional JavaScript -->
  <!-- jQuery first, then Popper.js, then Bootstrap JS -->
  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"
    crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"
    crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"
    crossorigin="anonymous"></script>
</body>
</html>
