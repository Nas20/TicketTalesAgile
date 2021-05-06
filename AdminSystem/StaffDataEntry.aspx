<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 644px;
        }
    </style>
</head>
<body style="height: 648px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" height="22px" Text="Staff Id" width="100px"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffPhoneNumber" runat="server" height="22px" Text="Staff Phone Number" width="100px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblStaffName" runat="server" height="22px" Text="Staff Name" width="100px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffEmail" runat="server" height="22px" Text="Staff Email" width="100px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffRoles" runat="server" height="22px" Text="Staff Roles" width="100px"></asp:Label>
        <asp:TextBox ID="txtRoles" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffDateOfBirth" runat="server" height="22px" Text="Staff Date Of Birth" width="100px"></asp:Label>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffGender" runat="server" Text="Staff Gender"></asp:Label>
        <asp:CheckBox ID="Female" runat="server" Checked="True" />
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Female"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="Male" runat="server" />
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Male"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server"  OnClick="btnCancel_Click" Text="Cancel" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
    </form>
</body>
</html>
