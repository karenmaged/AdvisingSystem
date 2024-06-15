<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentmenu.aspx.cs" Inherits="Advising_Team_24.Studentmenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .menu{
          margin-left:50px;
          margin-bottom:20px;
          height:150px;
          width:300px;
          background-color:aqua;
          font-weight:bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style=" text-align:center">

                                                            <asp:Button ID="Button21" runat="server" Text="Log Out" OnClick="Button21_Click" />
<br />
<br />

            <asp:Button ID="Button1" runat="server" Text="Add MobileNo" CssClass="menu" OnClick="Button1_Click" />

             <asp:Button ID="Button2" runat="server" Text="Optional Courses" CssClass="menu" OnClick="Button2_Click" /> <br />
            <asp:Button ID="Button3" runat="server" Text="Current Available Courses" CssClass="menu" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Required Courses" CssClass="menu" OnClick="Button4_Click" /> <br />
            <asp:Button ID="Button5" runat="server" Text="Missing Courses" CssClass="menu" OnClick="Button5_Click" />
             <asp:Button ID="Button6" runat="server" Text="Send Course Request" CssClass="menu" OnClick="Button6_Click" /> <br />
             <asp:Button ID="Button7" runat="server" Text="Send Credit HRS Request" CssClass="menu" OnClick="Button7_Click" />
             <asp:Button ID="Button8" runat="server" Text="First Makeup Registeration" CssClass="menu" OnClick="Button8_Click" /><br />
             <asp:Button ID="Button9" runat="server" Text="Second Makeup Registeration" CssClass="menu" OnClick="Button9_Click" />
             <asp:Button ID="Button10" runat="server" Text="View Instructor/Course Slot" CssClass="menu" OnClick="Button10_Click" /><br />
             <asp:Button ID="Button11" runat="server" Text="All Courses & Prerequisites" CssClass="menu" OnClick="Button11_Click" />
             <asp:Button ID="Button12" runat="server" Text="Choose Instructor" CssClass="menu" OnClick="Button12_Click" /><br />
             <asp:Button ID="Button13" runat="server" Text="Course & Exam Details" CssClass="menu" OnClick="Button13_Click" />
             <asp:Button ID="Button14" runat="server" Text="All Courses Details" CssClass="menu" OnClick="Button14_Click" /><br />
             <asp:Button ID="Button15" runat="server" Text="View Graduation Plan" CssClass="menu" OnClick="Button15_Click" />
             <asp:Button ID="Button16" runat="server" Text="View Upcoming Unpaid Installment Deadline" CssClass="menu" OnClick="Button16_Click" /><br />

        </div>
    </form>
</body>
</html>