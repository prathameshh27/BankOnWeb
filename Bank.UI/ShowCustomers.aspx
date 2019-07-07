<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Home.Master" CodeBehind="ShowCustomers.aspx.cs" Inherits="Bank.UI.ShowCustomers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Bank: Show Customers</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="HomeContentPlaceHolder" runat="server">

    <div>
        <asp:GridView ID="CustomersGridView" runat="server"></asp:GridView>
    </div>

</asp:Content>