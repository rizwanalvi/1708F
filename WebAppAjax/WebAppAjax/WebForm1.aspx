<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppAjax.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:APTECHDBConnectionString %>" SelectCommand="SELECT [BATCHID] FROM [VMSTDETAILS]"></asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="BATCHID" DataValueField="BATCHID" Height="22px" Width="139px" ></asp:DropDownList>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="BATCHID" DataValueField="BATCHID" Height="22px" Width="139px"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:APTECHDBConnectionString %>" SelectCommand="SELECT * FROM [VMSTDETAILS] WHERE ([BATCHID] = @BATCHID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="BATCHID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="STD_ID" HeaderText="STD_ID" SortExpression="STD_ID" />
                <asp:BoundField DataField="BATCHID" HeaderText="BATCHID" ReadOnly="True" SortExpression="BATCHID" />
                <asp:BoundField DataField="STD_NAME" HeaderText="STD_NAME" SortExpression="STD_NAME" />
                <asp:BoundField DataField="GENDER" HeaderText="GENDER" SortExpression="GENDER" />
                <asp:BoundField DataField="SEM_TITLE" HeaderText="SEM_TITLE" SortExpression="SEM_TITLE" />
                <asp:BoundField DataField="PROG_NAME" HeaderText="PROG_NAME" SortExpression="PROG_NAME" />
                <asp:BoundField DataField="EMAIL_ID" HeaderText="EMAIL_ID" SortExpression="EMAIL_ID" />
                <asp:BoundField DataField="SEM_ID" HeaderText="SEM_ID" SortExpression="SEM_ID" />
                <asp:BoundField DataField="ISSTC" HeaderText="ISSTC" SortExpression="ISSTC" />
                <asp:BoundField DataField="PRIM_NUM" HeaderText="PRIM_NUM" SortExpression="PRIM_NUM" />
                <asp:BoundField DataField="SECON_NUM" HeaderText="SECON_NUM" SortExpression="SECON_NUM" />
                <asp:BoundField DataField="SMS_NUM" HeaderText="SMS_NUM" SortExpression="SMS_NUM" />
                <asp:BoundField DataField="OTHER_NUM" HeaderText="OTHER_NUM" SortExpression="OTHER_NUM" />
                <asp:BoundField DataField="NO_ATTENDED" HeaderText="NO_ATTENDED" SortExpression="NO_ATTENDED" />
                <asp:BoundField DataField="STATUS" HeaderText="STATUS" SortExpression="STATUS" />
            </Columns>

        </asp:GridView>
        
            </ContentTemplate>
          <Triggers>
              <asp:AsyncPostBackTrigger ControlID="DropDownList2" EventName="SelectedIndexChanged" />
              <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
          </Triggers>
        </asp:UpdatePanel>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
