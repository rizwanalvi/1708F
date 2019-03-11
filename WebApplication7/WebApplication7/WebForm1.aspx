
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:1601DSTDConnectionString %>" SelectCommand="SELECT * FROM [STUDENTINFO]"></asp:SqlDataSource>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="BATCH_NO" DataValueField="BATCH_NO" Width="164px">
</asp:DropDownList>
           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

       
    <div>
 
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:1601DSTDConnectionString %>" SelectCommand="SELECT * FROM [STUDENTINFO] WHERE ([BATCH_NO] = @BATCH_NO)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="BATCH_NO" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowSorting="True" PageSize="5">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
            </Columns>
        </asp:GridView>
    </div>
                     </ContentTemplate>
               <Triggers>
                   <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
               </Triggers>

        </asp:UpdatePanel>
    </form>
</body>
</html>
