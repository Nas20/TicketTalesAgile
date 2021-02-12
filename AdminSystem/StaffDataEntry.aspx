<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 365px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffId" runat="server" height="22px" Text="Staff Id" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffPhoneNumber" runat="server" height="22px" Text="Staff Phone Number" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffPhoneNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblStaffName" runat="server" height="22px" Text="Staff Name" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffEmail" runat="server" height="22px" Text="Staff Email" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffRoles" runat="server" height="22px" Text="Staff Roles" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffRoles" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffDateOfBirth" runat="server" height="22px" Text="Staff Date Of Birth" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffDateOfBirth" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffGender" runat="server" Text="Staff Gender"></asp:Label>
        <asp:CheckBox ID="Female" runat="server" Checked="True" />
&nbsp;
        <asp:CheckBox ID="Male" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnok" runat="server" OnClick="btnok_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Cancel" />
    </form>
</body>
</html>
