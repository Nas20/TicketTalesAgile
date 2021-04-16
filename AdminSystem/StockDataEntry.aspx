<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblStockId" runat="server" Text="Stock ID" height="36px" width="203px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtStockId" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblItemName" runat="server" Text="Item Name " height="36px" width="203px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" height="36px" width="203px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" height="36px" width="203px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblStockAvailable" runat="server" Text="Stock Available"></asp:Label>
&nbsp;
            <asp:CheckBox ID="chkStockAvailable" runat="server" Text="Available" />
            <br />
            <br />
            <asp:Label ID="lblDatePurchased" runat="server" Text="Date Purchased" height="36px" width="203px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDatePurchased" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="FIND" Width="103px" />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" />
            <br />
            <asp:Button ID="btnCancel" runat="server" Text="CANCEL" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
