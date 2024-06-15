<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveRejectCourse.aspx.cs" Inherits="Advising_Team_24.ApproveRejectCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div style="text-align:center">
                                                <asp:Button ID="Button2" runat="server" Text="Back To Home Page" OnClick="Button2_Click" />
<br />
<br />
            <asp:Label ID="Label1" runat="server" Text="Request ID"></asp:Label><br /><br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="Select Request"></asp:ListItem>
            </asp:DropDownList><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Current Semester Code"></asp:Label><br /><br />
<asp:DropDownList ID="DropDownList2" runat="server">
<asp:ListItem Value="Select Semester"></asp:ListItem>
</asp:DropDownList><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Release" OnClick="Button1_Click" /> <br /><br />


        </div>
    </form>
</body>
</html>
