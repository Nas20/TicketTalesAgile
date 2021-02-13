<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" Text="Order ID: " width="226px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID:  " width="226px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address: " width="226px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderDispatchDate" runat="server" Text="Date to be Dispatched: "></asp:Label>
        <asp:TextBox ID="txtDispatchDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblItemName" runat="server" Text="Item Name: " width="226px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblitemQuantity" runat="server" Text="Item Quantity: " width="226px"></asp:Label>
        <asp:TextBox ID="txtItemQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderMade" runat="server" Text="Make Order? " width="226px"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" Text=" " />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
