<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebAppFormHandling.Index" UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table>
          <tr>
              <td> <asp:TextBox ID="TextBox1" runat="server" Width="202px" ></asp:TextBox></td>
               <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
          </tr>
           <tr>
              <td> <asp:TextBox ID="TextBox2" runat="server" Width="202px" TextMode="Number" ></asp:TextBox></td>
               <td>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Required" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                   <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Out of Range" ControlToValidate="TextBox2" MaximumValue="5" ForeColor="Red"></asp:RangeValidator> </td>
          </tr>
           <td> <asp:TextBox ID="TextBox3" runat="server" Width="202px" TextMode="Password" ></asp:TextBox>
               <asp:TextBox ID="TextBox4" runat="server" Width="202px" TextMode="Password" ></asp:TextBox>
           </td>
               <td>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Required" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Required" ForeColor="Red" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
                   
                   <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToValidate="TextBox4" ControlToCompare="TextBox3"></asp:CompareValidator> </td>
          </tr>
          <tr>
              <td>
                  <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox></td>
              <td>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox5" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator></td>
          </tr>
           <tr>
               <td>
                   <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                <td></td>
              
               </tr>
      </table>

       
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="78px" />
       
    
        <br />
       
    <table border="1" style="width:100%">
        <tr><td>NAME</td>
            <td>AGE</td>
            <td>PINCODE</td>
            <td>EMAIL</td>
              <td>PICTURE</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td><label id="lbage" runat="server"></label> </td>
            <td></td>
            <td></td>
            <td>
                <asp:Image ID="ImgPic" runat="server" Height="50px" Width="50px" /></td>
        </tr>
    </table>
    </div>
        <asp:GridView ID="GridView1" runat="server" Width="100%">
        </asp:GridView>
    </form>
</body>
</html>
