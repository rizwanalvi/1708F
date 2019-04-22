<%@ Page Title="" Language="C#" MasterPageFile="~/Eyewitness Panel/Eyewitness.master" AutoEventWireup="true" CodeFile="witeStory.aspx.cs" Inherits="Eyewitness_Panel_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script>
    </script>
     <!--main content start-->
    <section id="main-content">
      <section class="wrapper">
        
          <h1>Write Your Story Here you can update and delete your story </h1>

          <div class="row container">
              <div class="col-lg-12">
                  <br /><br />
                  <asp:Label ID="Label1" runat="server" Text="Select"></asp:Label>
                  <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                      <asp:ListItem>Stalking</asp:ListItem>
                      <asp:ListItem>Eve-teasing</asp:ListItem>
                      <asp:ListItem>Taking Picture</asp:ListItem>
                      <asp:ListItem>Harrasment</asp:ListItem>
                      <asp:ListItem>Crime</asp:ListItem>


                  </asp:DropDownList>

              </div>

          </div>
              <br /><br />
              <div class="row container">
              <div class="col-lg-12">
                  <asp:TextBox ID="TextBox1" runat="server" style="resize:none;" height="150px" cssclass="form-control col-lg-12" TextMode="MultiLine"></asp:TextBox>
      </div></div><br />
          <div class="row container">
              <div class="col-lg-12 center-block">
                   <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary btn-block" Text="Post Your Story" OnClick="Button1_Click" ></asp:Button>
      </div></div>






      </section>
    </section>
    <!--main content end-->

</asp:Content>

