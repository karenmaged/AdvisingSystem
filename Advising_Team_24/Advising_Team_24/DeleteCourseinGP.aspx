<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCourseinGP.aspx.cs" Inherits="Advising_Team_24.DeleteCourseinGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Button ID="Button2" runat="server" Text="Back To Home Page" OnClick="Button2_Click" />
<br />
<br />

            <asp:Label ID="sID" runat="server" Text="Student ID: " Font-Bold ForeColor="RoyalBlue"></asp:Label>
            <asp:DropDownList ID="StudentDropDown3" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Label ID="Semcode" runat="server" Text="Semester Code: " Font-Bold ForeColor="RoyalBlue"></asp:Label>
            <asp:DropDownList ID="SemDropDown2" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Label ID="courseID" runat="server" Text="Course Name: " Font-Bold ForeColor="RoyalBlue"></asp:Label>
            <asp:DropDownList ID="CourseDropd" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="deleteC" runat="server" OnClick="Delete_Course" Text="Delete" ForeColor="DarkRed" Font-Bold/>

        </div>
    </form>
</body>
</html>
