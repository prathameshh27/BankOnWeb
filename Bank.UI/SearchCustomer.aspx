<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCustomer.aspx.cs" Inherits="Bank.UI.SearchCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table title="Search Customer">
            <asp:Label ID="TableTitleLabel" runat="server" Text="Search Customers"></asp:Label>
            
            <tr><td></td></tr>
            <tr>
                <td>
                    <asp:Label ID="AccountTypeLabel" runat="server" Text="Account Type"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="AccountTypeTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text="Customer Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text="Customer Address &nbsp;"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            
            <tr><td></td><td></td></tr>

            <tr>
                <td></td>
                <td><asp:Button ID="searchCustomerButton"  Width="172px" runat="server" Text="Search" OnClick="SearchCustomerButton_Click" /></td>
            </tr>
            
            

            <tr>
                <td></td>
                <td><asp:Button ID="ResetButton" Width="172px" runat="server" Text="Reset" OnClick="ResetButton_Click" /></td>
            </tr>
        </table>

        <br/><br/>
        <asp:GridView ID="CustomerGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

    </div>
    </form>
</body>
</html>
