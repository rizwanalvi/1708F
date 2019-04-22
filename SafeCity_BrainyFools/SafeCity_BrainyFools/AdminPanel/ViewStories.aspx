<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/AdminWork.master" AutoEventWireup="true" CodeFile="ViewStories.aspx.cs" Inherits="AdminPanel_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <!--main content start-->
    <section id="main-content">
      <section class="wrapper">
        
          <h1>
              
             View Story  </h1>
              <br /><br />

          <asp:GridView ID="GridView1" class="table" AutoGenerateColumns="False" runat="server" Width="721px" OnRowUpdating="GridView1_RowUpdating">
              <Columns>
                  <asp:TemplateField HeaderText="ID">
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("UserId") %>'></asp:TextBox>
                      </EditItemTemplate>
                      <ItemTemplate>
                          <asp:Label ID="Label2" runat="server" Text='<%# Bind("auto_generated_id") %>'></asp:Label>
                      </ItemTemplate>
                  </asp:TemplateField>
                  <asp:BoundField DataField="category" HeaderText="Crime Category" />
                  <asp:BoundField DataField="descriptions" HeaderText="Description" />
                  <asp:BoundField DataField="dates" HeaderText="Date" />
                  <asp:BoundField DataField="status" HeaderText="Status" />
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

