﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="480px" Width="500px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="BtnAdd_Click" Text="Add" Width="86px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="85px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <asp:Label ID="lblEnterName" runat="server" Text="Please enter an Item name     "></asp:Label>
        <asp:TextBox ID="txtEnterName" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" Width="82px" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="82px" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
