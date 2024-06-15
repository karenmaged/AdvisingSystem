<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterationHome.aspx.cs" Inherits="Advising_Team_24.RegisterationHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="I am"></asp:ListItem>
                <asp:ListItem Value="Advisor"></asp:ListItem>
                <asp:ListItem Value="Student"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
