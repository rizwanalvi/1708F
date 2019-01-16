<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAppEx02.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:1601DASPConnectionString %>" DeleteCommand="DELETE FROM [UN_LIST] WHERE [UN_ID] = @original_UN_ID AND (([UN_NAME] = @original_UN_NAME) OR ([UN_NAME] IS NULL AND @original_UN_NAME IS NULL))" InsertCommand="INSERT INTO [UN_LIST] ([UN_NAME]) VALUES (@UN_NAME)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [UN_LIST]" UpdateCommand="UPDATE [UN_LIST] SET [UN_NAME] = @UN_NAME WHERE [UN_ID] = @original_UN_ID AND (([UN_NAME] = @original_UN_NAME) OR ([UN_NAME] IS NULL AND @original_UN_NAME IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_UN_ID" Type="Int32" />
                <asp:Parameter Name="original_UN_NAME" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UN_NAME" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UN_NAME" Type="String" />
                <asp:Parameter Name="original_UN_ID" Type="Int32" />
                <asp:Parameter Name="original_UN_NAME" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="UN_NAME" DataValueField="UN_ID" Height="22px" Width="170px">
        </asp:DropDownList>
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="UN_ID" DataSourceID="SqlDataSource1" PageSize="4">
            <Columns>
              
                <asp:BoundField DataField="UN_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="UN_ID" />
                <asp:BoundField DataField="UN_NAME" HeaderText="UN_NAME" SortExpression="UN_NAME" />
                  <asp:CommandField ShowDeleteButton="false" ShowEditButton="True" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="UN_ID" DataSourceID="SqlDataSource1" Width="100%">
            <EditItemTemplate>
                UN_ID:
                <asp:Label ID="UN_IDLabel1" runat="server" Text='<%# Eval("UN_ID") %>' />
                <br />
                UN_NAME:
                <asp:TextBox ID="UN_NAMETextBox" runat="server" Text='<%# Bind("UN_NAME") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                UN_NAME:
                <asp:TextBox ID="UN_NAMETextBox" runat="server" Text='<%# Bind("UN_NAME") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                UN_ID:
                <asp:Label ID="UN_IDLabel" runat="server" Text='<%# Eval("UN_ID") %>' />
                <br />
                UN_NAME:
                <asp:Label ID="UN_NAMELabel" runat="server" Text='<%# Bind("UN_NAME") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="UN_NAME" DataValueField="UN_ID" Height="22px" Width="170px" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:1601DASPConnectionString %>" SelectCommand="SELECT * FROM [UN_PROGRAMS] WHERE ([UN_ID] = @UN_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList2" DefaultValue="0" Name="UN_ID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" Width="100%">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="UN_ID" HeaderText="UN_ID" SortExpression="UN_ID" />
                <asp:BoundField DataField="PROG_NAME" HeaderText="PROG_NAME" SortExpression="PROG_NAME" />
                <asp:BoundField DataField="ADM_PERCENT" HeaderText="ADM_PERCENT" SortExpression="ADM_PERCENT" />
            </Columns>
        </asp:GridView>
      
        <asp:FileUpload ID="FileUpload1" runat="server" />
      
    </form>
</body>
</html>
