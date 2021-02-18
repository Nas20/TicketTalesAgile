<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="132px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <p class="auto-style1">
                <asp:Label ID="lblCustomerName" runat="server" Text=" Name" width="132px"></asp:Label>
                <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            </p>
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" width="132px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            <p class="auto-style1">
                <asp:Label ID="lblCustomerPassword" runat="server" Text=" Password" width="132px"></asp:Label>
                <asp:TextBox ID="txtCustomerPassword" runat="server"></asp:TextBox>
            </p>
            <asp:Label ID="lblCustomerAddress" runat="server" Text=" Address" width="132px"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
            <p class="auto-style1">
                <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
                <asp:TextBox ID="txtCustomerDateOfBirth" runat="server"></asp:TextBox>
            </p>
            <asp:CheckBox ID="chkActive" runat="server" Text=" Active" />
            <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
        </div>
        <p>
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
