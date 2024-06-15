<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courseinfo.aspx.cs" Inherits="Advising_Team_24.courseinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Button ID="mainmenu" runat="server" Text="Back to Main Menu" OnClick="mainmenu_Click" /><br/>
             <asp:DropDownList ID="alo2" runat="server">
             </asp:DropDownList>
             <asp:DropDownList ID="alo1" runat="server">
             </asp:DropDownList><br />
             <asp:Button ID="b" runat="server" Text="Choose " OnClick = "b_click" /><br />
            <%-- <asp:Label ID="courseid" runat="server" Text="Course ID  "></asp:Label>
             <asp:Label ID="coursename" runat="server" Text="Course Name  "></asp:Label>
             <asp:Label ID="slotid" runat="server" Text="Slot ID  "></asp:Label>
             <asp:Label ID="day" runat="server" Text="Day  "></asp:Label>
             <asp:Label ID="slot" runat="server" Text="Time  "></asp:Label>
             <asp:Label ID="loc" runat="server" Text="Location  "></asp:Label>
             <asp:Label ID="insid" runat="server" Text="Instructor ID  "></asp:Label>
             <asp:Label ID="ins" runat="server" Text="Instructor  "></asp:Label>--%>
        </div>
    </form>
</body>
</html>
