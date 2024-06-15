<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="firstmakeup.aspx.cs" Inherits="Advising_Team_24.firstmakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="mainmenu" runat="server" Text="Back to Main Menu" OnClick="mainmenu_Click" /><br/>
             <asp:DropDownList ID="ddm_c" runat="server">
             </asp:DropDownList>
             <asp:DropDownList ID="ddm_s" runat="server">
             </asp:DropDownList>
             <asp:Button ID="b" runat="server" Text="Choose " OnClick = "b_click" />
        </div>
    </form>
</body>
</html>