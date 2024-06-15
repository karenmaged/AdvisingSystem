<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertCourseinGP.aspx.cs" Inherits="Advising_Team_24.InsertCourseinGP" %>

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
             <asp:Label ID="Label1" runat="server" Text="Please add Course into Graduation Plan  " ForeColor="Red" Font-Bold Font-Underline></asp:Label> <br /><br/>
            <asp:Label ID="sid" runat="server" Text="Student ID:  " ForeColor="RoyalBlue" Font-Bold></asp:Label>
           <asp:DropDownList ID="StudentDropDown1" runat="server"></asp:DropDownList>
          <br /><br />
            <asp:Label ID="semCode" runat="server" Text="Semester Code: " ForeColor="RoyalBlue" Font-Bold></asp:Label>
           <asp:DropDownList ID="SemDropDown1" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Label ID="course" runat="server" Text="Course Name: " ForeColor="RoyalBlue" Font-Bold ></asp:Label>
            <asp:DropDownList ID="CourseDropDown" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="end" runat="server" OnClick="Submit_Course" Text="Submit" ForeColor="DarkRed" Font-Bold />
        </div>
    </form>
</body>
</html>
