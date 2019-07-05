<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCustomerForm.aspx.cs" Inherits="Bank.UI.CreateCustomerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Button ID="CreateSwitchButton" runat="server" Text="Create Customer" OnClick="CreateSwitchButton_Click" />
        <asp:Button ID="UpdateSwitchButton" runat="server" Text="Update Customer" OnClick="UpdateSwitchButton_Click" />
        <br/><br/>

        <table title="Customer Enrollment Form.">
            <asp:Label ID="TableTitleLabel" runat="server" Text="Customer Enrollment Form"></asp:Label>
            
            <tr><td></td></tr>
            <tr>
                <td>
                    <asp:Label ID="IdLabel" runat="server" Visible="false" Text="ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="IdTextBox" runat="server" Visible="false"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="AddressLabel" runat="server" Text="Address "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="AgeLabel" runat="server" Text="Age"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="AgeTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="MobileLabel" runat="server" Text="Mobile"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="MobileTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="GenderDropDownList" Width="130" runat="server">
                        <asp:ListItem Selected="True" Value="">Select</asp:ListItem>
                        <asp:ListItem Value="3">Other</asp:ListItem>
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            
            <tr><td></td><td></td></tr>

            <tr>
                <td></td>
                <td><asp:Button ID="CreateCustomerButton"  Width="130px" runat="server" Text="Submit" OnClick="CreateCustomerButton_Click" /></td>
            </tr>

            <tr>
                <td></td>
                <td><asp:Button ID="UpdateCustomerButton" Visible="false"  Width="130px" runat="server" Text="Submit" OnClick="UpdateCustomerButton_Click" /></td>
            </tr>
            
            <tr><td></td><td></td></tr>

            <tr>
                <td></td>
                <td><asp:Label ID="ResultLabel" runat="server" Text=" "></asp:Label></td>
                <td><asp:Button ID="ResetButton" runat="server" Text="Reset" Visible="false" OnClick="ResetButton_Click" /></td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
