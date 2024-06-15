<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhoneNo.aspx.cs" Inherits="Advising_Team_24.PhoneNo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .space{
            margin-left:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Back to Main Menu" OnClick="Button1_Click" /> <br /> <br />
            <asp:Label ID="Label1" runat="server" Text="Mobile No"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <asp:Button ID="Button2" runat="server" Text="Add"  CssClass="space" OnClick="Button2_Click"/> <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>