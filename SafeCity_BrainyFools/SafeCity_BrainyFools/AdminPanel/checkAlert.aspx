<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminWork.master" AutoEventWireup="true" CodeFile="checkAlert.aspx.cs" Inherits="AdminPanel_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <!--main content start-->
    <section id="main-content">
      <section class="wrapper">
        
          <h1>Check Alerts</h1>

          <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br /> <br /><br />

          

          <asp:GridView ID="GridView1" class="table" AutoGenerateColumns="False" runat="server" Width="721px" OnRowUpdating="GridView1_RowUpdating">
              <Columns>
                  <asp:TemplateField HeaderText="ID">
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("UserId") %>'></asp:TextBox>
                      </EditItemTemplate>
                      <ItemTemplate>
                          <asp:Label ID="Label2" runat="server" Text='<%# Bind("userid") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:BoundField DataField="first_name" HeaderText="First Name" />
                  <asp:BoundField DataField="last_name" HeaderText="Last Name" />
                  <asp:TemplateField HeaderText="E-mail">
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("email_id") %>'></asp:TextBox>
                      </EditItemTemplate>
                      <ItemTemplate>
                          <asp:Label ID="Label3" runat="server" Text='<%# Bind("email_id") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:BoundField DataField="contact" HeaderText="Contatc Info." />
                  <asp:BoundField DataField="locations" HeaderText="Location" />
                  <asp:BoundField DataField="dates" HeaderText="Dates" />
                  <asp:BoundField DataField="times" HeaderText="Date time" />
                  <asp:BoundField DataField="complain" HeaderText="Complain" />
                  <asp:BoundField DataField="status" HeaderText="status" />
                  <asp:TemplateField HeaderText="Operation">
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                      </EditItemTemplate>
                      <ItemTemplate>
                          <asp:LinkButton CssClass="btn btn-success btn-round" ID="LinkButton2" runat="server" CommandName="Update">Approve</asp:LinkButton>
                          <asp:Label ID="Label1" runat="server"></asp:Label>
                          <asp:LinkButton ID="LinkButton1" runat="server"></asp:LinkButton>
                      </ItemTemplate>
                  </asp:TemplateField>
              </Columns>
          </asp:GridView>






      </section>
    </section>
    <!--main content end-->


</asp:Content>

