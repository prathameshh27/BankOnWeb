<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Bank.UI.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bank: Login</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <table>
                            
                <tr>
                    <td> <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label> </td>
                    <td> <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox> </td>  
                </tr>
            
                <tr>
                    <td> <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label> </td>
                    <td> <asp:TextBox ID="PasswordTextBox" TextMode="Password" runat="server"></asp:TextBox> </td>  
                </tr>

                <tr> <td></td> </tr>

                <tr>
                    <td></td>
                    <td> <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" /> </td>
                </tr>

            </table>
        </div>

    </form>
</body>
</html>
