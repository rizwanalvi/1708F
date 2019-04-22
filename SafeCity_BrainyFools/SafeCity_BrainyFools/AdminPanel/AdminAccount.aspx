<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminWork.master" AutoEventWireup="true" CodeFile="AdminAccount.aspx.cs" Inherits="AdminPanel_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <!--main content start-->
    <section id="main-content">
      <section class="wrapper">
        
          <h1 style="color:black; font-weight:bold; margin-top:50px; ">Admin Account</h1>
         <h1 style="color:lawngreen; font-weight:bold; margin-top:50px; ">
             <asp:Label ID="Label2" runat="server" Text=""></asp:Label></h1>

          <div class="row">

              <div class="col-lg-6" style="border:0px solid red;">
                  <br /><br />
                  Admin Id : <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br /><br />
                   <div class="form-group">
    <label for="email">Name :</label>
     <asp:TextBox ID="TextBox1"  Cssclass="form-control" runat="server"></asp:TextBox>

  </div>
  <div class="form-group">
    <label for="pwd">Last Name:</label>

      <asp:TextBox ID="TextBox2" Cssclass="form-control" runat="server"></asp:TextBox>
  </div>

<div class="form-group">
    <label for="pwd"> Email :</label>

      <asp:TextBox ID="TextBox3" Cssclass="form-control" runat="server"></asp:TextBox>
  </div>

  <div class="form-group">
    <label for="pwd">Password:</label>

      <asp:TextBox ID="TextBox4" Cssclass="form-control" runat="server" ></asp:TextBox>
  </div>


<div class="form-group">
    <label for="pwd">Contact No:</label>

      <asp:TextBox ID="TextBox5" Cssclass="form-control" runat="server" ></asp:TextBox>
  </div>
                  
                  <asp:FileUpload ID="FileUpload1" runat="server" />
                  <br/><br/>
          <asp:Button ID="Button1" Cssclass="btn btn-default" runat="server" Text="Update" OnClick="Button1_Click" />


              </div>

              <div class="col-lg-6" style="border:0px solid red;">

                  <asp:Image ID="Image1" CssClass="img-circle" runat="server" Width="200" Height="200" />
                  <h1>Other Details</h1>
                  <p style="font-family:sans-serif">
                      Professionally printed material in English typically does not indent the first paragraph, but indents those that follow. For example, Robert Bringhurst states that we should "Set opening paragraphs flush left."[3] Bringhurst explains as follows:

The function of a paragraph is to mark a pause, setting the paragraph apart from what precedes it. If a paragraph is preceded by a title or subhead, the indent is superfluous and can therefore be omitted.[3]
                  </p>
                  <p style="font-family:sans-serif; color:orangered;">
                      Note : To Update your profile you must have to UPDATE your profile picture.
                  </p>

              </div>



          </div> 

        

      </section>
    </section>
    <!--main content end-->


</asp:Content>

