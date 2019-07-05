<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bank.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="ShowCustomersButton" runat="server" Text="Show Customers" OnClick="ShowCustomersButton_Click" />
        <br />
        <asp:GridView ID="CustomersGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
