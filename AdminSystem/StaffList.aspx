<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #lblError {
            height: 696px;
        }
        #lblError0 {
            height: 668px;
        }
    </style>
</head>
<body style="height: 698px">
    <form id="lblError" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="518px" Width="871px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        &nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        </p>
        Enter a name <input id="txtEnterName" type="text" /><br />
        <br />
        <br />
        <asp:Label ID="lblErrors" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
